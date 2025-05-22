using System.Data.OleDb;
using Core;
using Core.Purchases;
using Core.Purchases.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Purchases;

public class PurchaseRepository : IPurchaseRepository
{
    private readonly string _connectionString;

    public PurchaseRepository(ConnectionStrings connectionStrings)
    {
        ArgumentNullException.ThrowIfNull(connectionStrings);
        _connectionString = connectionStrings.Database;
    }

    public int? Add(Purchase purchase)
    {
        using var connection = new OleDbConnection(_connectionString);
        connection.Open();
        using var transaction = connection.BeginTransaction();
        try
        {
            var now = DateTime.Now;
            var ticket = connection.QueryFirstOrDefault<(int Id, int Price)?>(
                $"SELECT Id, Price FROM Tickets WHERE Id = {purchase.TicketId};",
                transaction: transaction);
            
            if (!ticket.HasValue)
            {
                transaction.Commit();
                return null;
            }

            var totalPrice = ticket.Value.Price;
            int? menuItemId = null;

            if (!string.IsNullOrEmpty(purchase.MenuItems))
            {
                var menuItem = connection.QueryFirstOrDefault<(int Id, int Price)?>(
                    $"SELECT Id, Price FROM MenuItems WHERE DisplayName = '{purchase.MenuItems}' AND IsAvailable = True;",
                    transaction: transaction);
                
                if (menuItem.HasValue)
                {
                    menuItemId = menuItem.Value.Id;
                    totalPrice += menuItem.Value.Price;
                }
            }

            int? promotionId = null;
            int discountAmount = 0;

            if (!string.IsNullOrEmpty(purchase.PromotionName))
            {
                var promotion = connection.QueryFirstOrDefault<(int Id, int DiscountPercent)?>(
                    $"SELECT Id, DiscountPercent FROM Promotions WHERE DisplayName = '{purchase.PromotionName}';",
                    transaction: transaction);
                
                if (promotion.HasValue)
                {
                    promotionId = promotion.Value.Id;
                    discountAmount = (totalPrice * promotion.Value.DiscountPercent) / 100;
                    totalPrice -= discountAmount;
                }
            }

            connection.Execute(
                $"INSERT INTO Purchases(TicketId, MenuItemId, TotalPrice, PurchaseDateTime) VALUES({ticket.Value.Id}, {(menuItemId.HasValue ? menuItemId.Value.ToString() : "NULL")}, {totalPrice}, '{now.ToShortDateString()}');",
                transaction: transaction);

            var purchaseId = connection.QueryFirst<int>("SELECT @@IDENTITY;", transaction: transaction);

            if (promotionId.HasValue)
            {
                connection.Execute(
                    $"INSERT INTO AppliedDiscounts(PurchaseId, PromotionId, DiscountAmount) VALUES({purchaseId}, {promotionId.Value}, {discountAmount});",
                    transaction: transaction);
            }

            connection.Execute(
                $"UPDATE Tickets SET PurchaseDateTime = '{now}' WHERE Id = {ticket.Value.Id};",
                transaction: transaction);

            transaction.Commit();
            return totalPrice;
        }
        catch
        {
            transaction.Rollback();
            return null;
        }
        finally
        {
            connection.Close();
        }
    }

    public Result Delete()
    {
        using var connection = new OleDbConnection(_connectionString);
        connection.Open();
        using var transaction = connection.BeginTransaction();
        try
        {
            var purchaseId = connection.QueryFirstOrDefault<int?>(
                "SELECT TOP 1 Id FROM Purchases ORDER BY PurchaseDateTime DESC;",
                transaction: transaction);
            
            if (!purchaseId.HasValue)
            {
                transaction.Commit();
                return Result.Failure();
            }

            connection.Execute(
                $"DELETE FROM AppliedDiscounts WHERE PurchaseId = {purchaseId.Value};",
                transaction: transaction);

            connection.Execute(
                $"UPDATE Tickets SET PurchaseDateTime = NULL WHERE Id IN (SELECT Ticked FROM Purchases WHERE Id = {purchaseId.Value});",
                transaction: transaction);

            connection.Execute(
                $"DELETE FROM Purchases WHERE Id = {purchaseId.Value};",
                transaction: transaction);

            transaction.Commit();
            return Result.Success();
        }
        catch
        {
            transaction.Rollback();
            return Result.Failure();
        }
        finally
        {
            connection.Close();
        }
    }
}
