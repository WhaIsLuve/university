using System.Data.OleDb;
using Core;
using Core.Screenings;
using Core.Screenings.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Screenings;

public class ScreeningRepository : IScreeningRepository
{
	private readonly string _connectionString;

	public ScreeningRepository(ConnectionStrings connectionStrings)
	{
		ArgumentNullException.ThrowIfNull(connectionStrings);
		_connectionString = connectionStrings.Database;
	}

	public Result Add(Screening screening)
	{
		const string checkMovieQuery = "SELECT Id FROM Movies WHERE DisplayName = @MovieName;";
		const string getHallQuery = "SELECT Id, Capacity FROM Halls WHERE DisplayName = @HallName;";
		const string getSeatsQuery = "SELECT Id FROM Seats WHERE HallId = @HallId ORDER BY Row, SeatNumber;";
		const string checkScreeningQuery = @"SELECT Id FROM Screenings 
            WHERE MovieId = @MovieId AND HallId = @HallId;";
		const string getLastScreeningIdQuery = "SELECT @@IDENTITY;";
		const string insertTicketQuery = @"INSERT INTO Tickets(ScreeningId, SeatId, Price) 
            VALUES(@ScreeningId, @SeatId, @Price);";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var movieId = connection.QueryFirstOrDefault<int?>(checkMovieQuery,
															   new
															   {
																   MovieName = screening.MovieName
															   },
															   transaction: transaction);
			if (!movieId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			var hall = connection.QueryFirstOrDefault<(int Id, int Capacity)?>(getHallQuery,
																			   new
																			   {
																				   HallName = screening.HallName
																			   },
																			   transaction: transaction);
			if (!hall.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			var existingId = connection.QueryFirstOrDefault<int?>(checkScreeningQuery,
																  new
																  {
																	  MovieId = movieId,
																	  HallId = hall.Value.Id
																  },
																  transaction: transaction);
			if (existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			var insertScreeningQuery = $@"INSERT INTO Screenings(MovieId, HallId, StartDateTime, EndDateTime)
            VALUES({movieId}, {hall.Value.Id}, '{screening.StartDateTime}', '{screening.EndDateTime}');";
			connection.Execute(insertScreeningQuery,
							   transaction: transaction);

			var screeningId = connection.QueryFirst<int>(getLastScreeningIdQuery, transaction: transaction);

			var seats = connection.Query<int>(getSeatsQuery,
											  new
											  {
												  HallId = hall.Value.Id
											  },
											  transaction: transaction);

			foreach (var seatId in seats)
			{
				connection.Execute(insertTicketQuery,
								   new
								   {
									   ScreeningId = screeningId,
									   SeatId = seatId,
									   Price = screening.Price
								   },
								   transaction: transaction);
			}

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

	public IEnumerable<Screening> GetScreenings()
	{
		const string query = @"SELECT DISTINCT 
		    s.Id, 
		    m.DisplayName AS MovieName, 
		    h.DisplayName AS HallName, 
		    t.Price,
		    s.StartDateTime, 
		    s.EndDateTime 
		FROM ((Screenings s
		INNER JOIN Movies m ON s.MovieId = m.Id)
		INNER JOIN Halls h ON s.HallId = h.Id)
		INNER JOIN Tickets t ON t.ScreeningId = s.Id";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<Screening>(query);
		connection.Close();
		return result;
	}

	public Result Update(Screening screening)
	{
		const string updateTicketsQuery = @"UPDATE Tickets SET 
            Price = @Price 
            WHERE ScreeningId = @ScreeningId AND PurchaseDateTime IS NULL;";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var updateScreeningQuery = $@"UPDATE Screenings SET 
	            StartDateTime = '{screening.StartDateTime}', 
	            EndDateTime = '{screening.EndDateTime}' 
	            WHERE Id = {screening.Id};";
			connection.Execute(updateScreeningQuery,
							   transaction: transaction);

			connection.Execute(updateTicketsQuery,
							   new
							   {
								   Price = screening.Price,
								   ScreeningId = screening.Id
							   },
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

	public Result Delete(Screening screening)
	{
		const string deleteTicketsQuery = "DELETE FROM Tickets WHERE ScreeningId = @ScreeningId;";
		const string deleteScreeningQuery = "DELETE FROM Screenings WHERE Id = @Id;";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			connection.Execute(deleteTicketsQuery,
							   new
							   {
								   ScreeningId = screening.Id
							   },
							   transaction: transaction);

			connection.Execute(deleteScreeningQuery,
							   new
							   {
								   screening.Id
							   },
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

	public IEnumerable<(int Row, int SeatNumber, int TicketId)> GetSeatTickets(int scrId)
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<(int, int, int)>(
			$"SELECT s.Row, s.SeatNumber, t.Id FROM (Tickets t INNER JOIN Seats s ON t.SeatId = s.Id) WHERE t.ScreeningId = {scrId} AND t.PurchaseDateTime IS NULL");
		connection.Close();
		return result;
	}
}
