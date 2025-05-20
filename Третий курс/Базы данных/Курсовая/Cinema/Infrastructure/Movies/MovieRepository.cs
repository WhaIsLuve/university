using System.Data.OleDb;
using Core;
using Core.Genres;
using Core.Movies;
using Core.Movies.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Movies;

public class MovieRepository : IMovieRepository
{
	private readonly string _connectionString;

	public MovieRepository(ConnectionStrings connectionStrings)
	{
		ArgumentNullException.ThrowIfNull(connectionStrings);
		_connectionString = connectionStrings.Database;
	}

	public IEnumerable<Movie> GetMovies()
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		const string getMovieQuery = $@"
			SELECT Movies.Id as {nameof(MovieDto.Id)}, 
				   Movies.DisplayName as {nameof(MovieDto.DisplayName)}, 
				   Movies.Rating as {nameof(MovieDto.Rating)}, 
				   Movies.Duration as {nameof(MovieDto.Duration)}, 
				   Movies.Country as {nameof(MovieDto.Country)}
			FROM Movies;
		   ";

		const string getMovieGenresQuery = @$"
		SELECT 
				MovieGenres.MovieId AS {nameof(MovieGenreDto.MovieId)},
				g.Id AS {nameof(MovieGenreDto.GenreId)},
				g.DisplayName as {nameof(MovieGenreDto.DisplayName)}
			FROM MovieGenres
			INNER JOIN Genres g ON MovieGenres.GenreId = g.Id;
		";

		var movieDtos = connection.Query<MovieDto>(getMovieQuery);
		var movieGenres = connection.Query<MovieGenreDto>(getMovieGenresQuery);

		connection.Close();

		var genresByMovie = movieGenres.GroupBy(g => g.MovieId)
									   .ToDictionary(g => g.Key, g => string.Join(", ", g.Select(x => x.DisplayName)));

		return movieDtos.Select(m => new Movie(m.DisplayName,
											   m.Rating,
											   TimeSpan.Parse(m.Duration),
											   m.Country,
											   genresByMovie.TryGetValue(m.Id, out var genres) ? genres : string.Empty));
	}

	public Result Delete(Movie movie)
	{
		const string findIdQuery = @"
		SELECT Id FROM Movies 
		WHERE DisplayName = @DisplayName 
		AND Duration = @Duration 
		AND Country = @Country 
		AND Rating = @Rating";

		const string deleteMovieGenresQuery = @"DELETE FROM MovieGenres WHERE MovieGenres.MovieId = @MovieId";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(findIdQuery,
				new
				{
					movie.DisplayName,
					Duration = movie.Duration.ToString(),
					movie.Country,
					movie.Rating
				},
				transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			if (movie.Genres.Length > 1)
			{
				connection.Execute(deleteMovieGenresQuery,
					new { MovieId = existingId.Value },
					transaction: transaction);
			}

			var deleteQuery = $@"
			delete from Movies where Movies.Id = {existingId};";


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

	public Result Update(Movie oldData, Movie movie)
	{
		const string findIdQuery = @"
		SELECT Id FROM Movies 
		WHERE DisplayName = @DisplayName 
		AND Duration = @Duration 
		AND Country = @Country 
		AND Rating = @Rating";

		const string deleteMovieGenresQuery = @"DELETE FROM MovieGenres WHERE MovieGenres.MovieId = @MovieId";
		const string insertMovieGenresQuery = @"INSERT INTO MovieGenres(MovieGenres.MovieId, MovieGenres.GenreId) VALUES(@MovieId, @GenreId)";
		const string queryGenre = @"SELECT Id FROM Genres WHERE Genres.DisplayName = @DisplayName";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(findIdQuery,
				new
				{
					oldData.DisplayName,
					Duration = oldData.Duration.ToString(),
					oldData.Country,
					oldData.Rating
				},
				transaction: transaction);

			if (!existingId.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			var check = connection.QueryFirstOrDefault<int?>(findIdQuery,
				new
				{
					movie.DisplayName,
					Duration = movie.Duration.ToString(),
					movie.Country,
					movie.Rating
				},
				transaction: transaction);
			if(check.HasValue)
			{
				transaction.Commit();
				return Result.Failure();
			}

			var updateQuery = $@"
			UPDATE Movies 
			SET Movies.DisplayName = '{movie.DisplayName}', 
				Movies.Duration = '{movie.Duration}', 
				Movies.Country = '{movie.Country}', 
				Movies.Rating = {movie.Rating}
			WHERE Movies.Id = {existingId}";

			
			connection.Execute(updateQuery,
				transaction: transaction);

			if(oldData.Genres.Length > 1)
			{
				connection.Execute(deleteMovieGenresQuery,
					new { MovieId = existingId.Value },
					transaction: transaction);
			}

			if (movie.Genres.Length > 0) 
			{
				var genreId = connection.QueryFirst<int>(queryGenre,
					new { DisplayName = movie.Genres },
					transaction: transaction);

				connection.Execute(insertMovieGenresQuery,
					new
					{
						MovieId = existingId.Value,
						GenreId = genreId
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

	public Result Add(Movie movie)
	{
		const string checkQuery = @"
		SELECT Id FROM Movies 
		WHERE DisplayName = @DisplayName 
		AND Duration = @Duration 
		AND Country = @Country 
		AND Rating = @Rating";

		const string insertQuery = @"
		INSERT INTO Movies (DisplayName, Duration, Country, Rating) 
		VALUES (@DisplayName, @Duration, @Country, @Rating)";
		const string insertMovieGenresQuery = @"insert into MovieGenres(MovieId, GenreId) values(@MovieId, @GenreId)";
		const string queryGenre = @"SELECT Genres.Id FROM Genres WHERE Genres.DisplayName = @DisplayName";

		const string getIdQuery = "SELECT @@IDENTITY";

		using var connection = new OleDbConnection(_connectionString);
		connection.Open();

		using var transaction = connection.BeginTransaction();

		try
		{
			var existingId = connection.QueryFirstOrDefault<int?>(checkQuery,
																  new
																  {
																	  movie.DisplayName,
																	  Duration = movie.Duration.ToString(),
																	  movie.Country,
																	  movie.Rating
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
								   movie.DisplayName,
								   Duration = movie.Duration.ToString(),
								   movie.Country,
								   movie.Rating
							   },
							   transaction: transaction);

			var newId = connection.QueryFirst<int>(getIdQuery, transaction: transaction);
			if(movie.Genres.Length > 0)
			{
				var genreId = connection.QueryFirst<int>(queryGenre,
														 transaction: transaction,
														 param: new
														 {
															 DisplayName = movie.Genres
														 });
				connection.Execute(insertMovieGenresQuery,
								   new
								   {
									   MovieId = newId,
									   GenreId = genreId
								   },
								   transaction);
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

	private class MovieDto
	{
		public int Id
		{
			get;
			set;
		}

		public string DisplayName
		{
			get;
			set;
		}

		public int Rating
		{
			get;
			set;
		}

		public string Duration
		{
			get;
			set;
		}

		public string? Country
		{
			get;
			set;
		}
	}

	private class MovieGenreDto
	{
		public int MovieId
		{
			get;
			set;
		}

		public int GenreId
		{
			get;
			set;
		}

		public string DisplayName
		{
			get;
			set;
		}
	}
}
