using System.Data.OleDb;
using Core;
using Core.Halls;
using Core.Halls.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Halls;

public class HallRepository : IHallRepository
{
	private readonly string _connectionString;

	public HallRepository(ConnectionStrings connectionStrings)
	{
		ArgumentNullException.ThrowIfNull(connectionStrings);
		_connectionString = connectionStrings.Database;
	}

	public Result Add(Hall hall)
	{
		const string checkQuery = @"
		SELECT Id FROM Halls 
		WHERE DisplayName = @DisplayName";

		const string insertQuery = @"
		INSERT INTO Halls (DisplayName, Capacity) 
		VALUES (@DisplayName, @Capacity)";
		const string insertSeatsByHall = @"insert into Seats(HallId, Row, SeatNumber) values(@HallId, @Row, @SeatNumber)";

		const string getIdQuery = "SELECT @@IDENTITY";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(checkQuery,
																  new
																  {
																	  hall.DisplayName,
																  },
																  transaction: transaction);

			if (existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			connection.Execute(insertQuery,
							   new
							   {
								   hall.DisplayName,
								   hall.Capacity
							   },
							   transaction: transaction);

			var newId = connection.QueryFirst<int>(getIdQuery, transaction: transaction);

			var fullRows = hall.Capacity / 10;
			var remainingSeats = hall.Capacity % 10;
			var totalRows = fullRows + (remainingSeats > 0 ? 1 : 0);

			for (var row = 1; row <= fullRows; row++)
			{
				for (var seatNumber = 1; seatNumber <= 10; seatNumber++)
				{
					connection.Execute(insertSeatsByHall,
									   new
									   {
										   HallId = newId,
										   Row = row,
										   SeatNumber = seatNumber
									   },
									   transaction: transaction);
				}
			}

			if (remainingSeats > 0)
			{
				connection.Execute(insertSeatsByHall,
								   new
								   {
									   HallId = newId,
									   Row = totalRows,
									   SeatNumber = remainingSeats
								   },
								   transaction: transaction);
			}

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

	public IEnumerable<Hall> GetHalls()
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<Hall>($"SELECT Halls.DisplayName, Halls.Capacity FROM Halls");
		connection.Close();
		return result;
	}

	public Result Delete(string hallName)
	{
		const string findIdQuery = @"
		SELECT Id FROM Halls 
		WHERE DisplayName = @DisplayName;";

		const string deleteSeats = @"DELETE FROM Seats WHERE Seats.HallId = @HallId";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(findIdQuery,
																  new
																  {
																	  DisplayName = hallName
																  },
																  transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			connection.Execute(deleteSeats,
							   new
							   {
								   HallId = existingId.Value
							   },
							   transaction: transaction);

			var deleteQuery = $@"
			delete from Halls where Halls.Id = {existingId};";

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

	public IEnumerable<Seat> GetAllSeatsByHallName(string hallName)
	{
		const string findIdQuery = @"
		SELECT Id FROM Halls 
		WHERE DisplayName = @DisplayName;";
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(findIdQuery,
																  new
																  {
																	  DisplayName = hallName
																  },
																  transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return [];
			}

			var result = connection.Query<Seat>($"SELECT Seats.Row, Seats.SeatNumber FROM Seats WHERE Seats.HallId = {existingId}", transaction: transaction);

			transaction.Commit();
			return result;
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
