using System.Data.OleDb;
using Core;
using Core.Genres;
using Core.Genres.Repositories;
using Core.Movies;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Genres;

public class GenreRepository : IGenreRepository
{
	private readonly string _connectionString;

	public GenreRepository(ConnectionStrings connectionStrings)
	{
		ArgumentNullException.ThrowIfNull(connectionStrings);
		_connectionString = connectionStrings.Database;
	}

	public Result Update(string oldName, Genre genre)
	{
		const string queryGenre = @"SELECT Id FROM Genres WHERE Genres.DisplayName = @DisplayName";
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
				DisplayName = genre.DisplayName,
			});
			if(check.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}
			var updateQuery = $@"
				UPDATE Genres 
				SET Genres.DisplayName = '{genre.DisplayName}'
				WHERE Genres.Id = {existingId}";
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

	public Result Delete(string genreName)
	{
		const string queryGenre = @"SELECT Id FROM Genres WHERE Genres.DisplayName = @DisplayName";
		const string countMovieGenre = @"SELECT COUNT(*) FROM MovieGenres WHERE GenreId = @id;";
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(queryGenre,
				new
				{
					DisplayName = genreName
				},
				transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}
			var countMovieWithGenre = connection.QueryFirstOrDefault<int?>(countMovieGenre,
				new
				{
					id = existingId.Value
				},
				transaction: transaction);
			if (countMovieWithGenre.HasValue && countMovieWithGenre.Value > 0)
			{
				transaction.Commit();
				return Result.Failure();
			}
			var deleteQuery = $@"
				delete from Genres where Id={existingId}";
			connection.Execute(deleteQuery,
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

	public Result Add(Genre genre)
	{
		const string insertQuery = $"insert into Genres({nameof(Genre.DisplayName)}) values(@DisplayName);";
		const string checkQuery = @"
		SELECT Id FROM Genres 
		WHERE DisplayName = @DisplayName;";
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(checkQuery,new
			{
				genre.DisplayName
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
								   genre.DisplayName
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

	public IEnumerable<Genre> GetGenres()
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<Genre>($"SELECT DisplayName as {nameof(Genre.DisplayName)} FROM Genres");
		connection.Close();
		return result;
	}
}
