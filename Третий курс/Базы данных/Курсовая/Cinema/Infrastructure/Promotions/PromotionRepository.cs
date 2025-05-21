using System.Data.OleDb;
using Core;
using Core.Promotions;
using Core.Promotions.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Promotions;

public class PromotionRepository : IPromotionRepository
{
	private readonly string _connectionString;

	public PromotionRepository(ConnectionStrings connectionStrings)
	{
		ArgumentNullException.ThrowIfNull(connectionStrings);
		_connectionString = connectionStrings.Database;
	}

	public Result Add(Promotion promotion)
	{
		const string checkQuery = @"
	    SELECT Id FROM Promotions 
	    WHERE DisplayName = @DisplayName;";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(checkQuery,
																  new
																  {
																	  promotion.DisplayName
																  },
																  transaction: transaction);

			if (existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}
			var insertQuery =
				$"insert into Promotions(DisplayName, DiscountPercent, StartDateTime, EndDateTime) values('{promotion.DisplayName}', {promotion.DiscountPercent}, '{promotion.StartDateTime.ToShortDateString()}', '{promotion.EndDateTime.Date.ToShortDateString()}');";

			connection.Execute(insertQuery,
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

	public IEnumerable<Promotion> GetPromotions()
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<Promotion>($@"
	    SELECT 
	        DisplayName as {nameof(Promotion.DisplayName)},
	        DiscountPercent as {nameof(Promotion.DiscountPercent)},
	        StartDateTime as {nameof(Promotion.StartDateTime)},
	        EndDateTime as {nameof(Promotion.EndDateTime)}
	    FROM Promotions");
		connection.Close();
		return result;
	}

	public Result Delete(string name)
	{
		const string checkQuery = @"
	    SELECT Id FROM Promotions 
	    WHERE DisplayName = @DisplayName;";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(checkQuery,
																  new
																  {
																	  DisplayName = name
																  },
																  transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}
			var query = $"DELETE FROM Promotions WHERE Promotions.Id = {existingId}";

			connection.Execute(query,
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
