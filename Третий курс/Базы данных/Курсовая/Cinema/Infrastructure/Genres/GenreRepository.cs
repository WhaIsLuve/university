using System.Data.OleDb;
using Core.Genres;
using Core.Genres.Repositories;
using Dapper;
using Infrastructure.Options;

namespace Infrastructure.Genres;

public class GenreRepository : IGenreRepository
{
	private readonly string _connectionString;

	public GenreRepository(ConnectionStrings connectionStrings)
	{
		_connectionString = connectionStrings.Database;
	}

	public void Add(Genre genre)
	{
		const string insertQuery = $"insert into Genres({nameof(Genre.DisplayName)}) values(@DisplayName);";
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		using var transaction = connection.BeginTransaction();
		connection.Execute(insertQuery,
						   transaction: transaction,
						   param: new
						   {
							   genre.DisplayName
						   });
		transaction.Commit();
		connection.Close();
	}

	public Genre[] Get()
	{
		using var connection = new OleDbConnection(_connectionString);
		connection.Open();
		var result = connection.Query<Genre>($"SELECT DisplayName as {nameof(Genre.DisplayName)} FROM Genres");
		connection.Close();
		return result.ToArray();
	}
}
