using System.Data.OleDb;
using Core;
using Core.MenuItems;
using Core.MenuItems.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.MenuItems;

public class MenuItemRepository : IMenuItemRepository
{
	private readonly string _connectionString;

	public MenuItemRepository(ConnectionStrings connectionStrings)
	{
		ArgumentNullException.ThrowIfNull(connectionStrings);
		_connectionString = connectionStrings.Database;
	}
	
	public Result Add(MenuItem menuItem)
	{
		const string insertQuery = $"insert into MenuItems(DisplayName, Price, IsAvailable) values(@DisplayName, @Price, True);";
		const string checkQuery = @"
		SELECT Id FROM MenuItems 
		WHERE DisplayName = @DisplayName;";
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(checkQuery,new
																  {
																	  menuItem.DisplayName
																  },
																  transaction: transaction);

			if (existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}
			connection.Execute(insertQuery,
							   transaction: transaction,
							   param: new
							   {
								   DisplayName = menuItem.DisplayName,
								   Price = menuItem.Price
							   });
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

	public IEnumerable<MenuItem> GetMenuItems()
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<MenuItem>($"SELECT MenuItems.DisplayName, MenuItems.Price, MenuItems.IsAvailable FROM MenuItems");
		connection.Close();
		return result;
	}

	public Result Update(string oldName, MenuItem menuItem)
	{
		const string queryGenre = @"
		SELECT Id FROM MenuItems 
		WHERE DisplayName = @DisplayName;";
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(queryGenre,
																  new
																  {
																	  DisplayName = oldName
																  },
																  transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}
			var check = connection.QueryFirstOrDefault<int?>(queryGenre, new
			{
				DisplayName = menuItem.DisplayName,
			}, transaction: transaction);
			if(check.HasValue && check.Value != existingId)
			{
				transaction.Commit();
				return Result.Failure();
			}

			var isAvailable = menuItem.IsAvailable ? "True" : "False";
			var updateQuery = $@"
				UPDATE MenuItems 
				SET MenuItems.DisplayName = '{menuItem.DisplayName}',
				    MenuItems.Price = {menuItem.Price},
				    MenuItems.IsAvailable = {isAvailable}
				WHERE MenuItems.Id = {existingId}";
			connection.Execute(updateQuery,
							   transaction: transaction);
			transaction.Commit();
			return Result.Success();
		}
		catch
		{
			transaction.Rollback();
			throw;
		}
		finally
		{
			connection.Close();
		}
	}

	public Result Delete(string name)
	{
		const string findIdQuery = @"
		SELECT Id FROM MenuItems 
		WHERE DisplayName = @DisplayName;";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(findIdQuery,
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

			var deleteQuery = $@"
			delete from MenuItems where MenuItems.Id = {existingId};";

			connection.Execute(deleteQuery, transaction: transaction);

			transaction.Commit();
			return Result.Success();
		}
		catch
		{
			transaction.Rollback();
			throw;
		}
		finally
		{
			connection.Close();
		}
	}
}
