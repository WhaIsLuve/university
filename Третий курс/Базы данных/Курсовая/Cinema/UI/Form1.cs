using Core.Genres.Repositories;
using Core.Movies;
using Core.Movies.Repositories;
using Infrastructure.Genres;
using Infrastructure.Movies;
using System.Data;
using UI.AddData;
using UI.ChangeData;
using UI.Helpers;

namespace UI;

public partial class Form1 : Form
{
	private readonly IMovieRepository _movieRepository;
	private readonly IGenreRepository _genreRepository;
	private Table? table;

	public Form1()
	{
		InitializeComponent();
		var connectionStrings = ConnectionStringGetter.ConnectionStrings;
		_movieRepository = new MovieRepository(connectionStrings);
		_genreRepository = new GenreRepository(connectionStrings);
	}

	private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateButton.Visible = true;
		deleteButton.Visible = true;
		table = Table.Movie;
		UpatedMovieTable();
	}

	private void UpatedMovieTable()
	{
		var dataTable = InitialTable("Наименование", "Рейтинг", "Длительность", "Страна", "Жанры");
		var movies = _movieRepository.GetMovies();

		foreach (var movie in movies)
		{
			dataTable.Rows.Add(movie.DisplayName, movie.Rating, movie.Duration, movie.Country, movie.Genres);
		}
		mainTable.DataSource = dataTable;
	}

	private void UpatedGenreTable()
	{
		var dataTable = InitialTable("Наименование");
		var genres = _genreRepository.GetGenres();
		foreach (var genre in genres)
		{
			dataTable.Rows.Add(genre.DisplayName);
		}
		mainTable.DataSource = dataTable;
	}

	private DataTable InitialTable(params string[] columnsName)
	{
		var dataTable = new DataTable();
		foreach (string columnName in columnsName)
		{
			dataTable.Columns.Add(columnName);
		}

		return dataTable;
	}

	private void genresToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateButton.Visible = true;
		deleteButton.Visible = true;
		table = Table.Genres;
		UpatedGenreTable();
	}

	private void createButton_Click(object sender, EventArgs e)
	{
		switch (table)
		{
			case Table.Movie:
				var addForm = new AddMovieForm();
				addForm.ShowDialog();
				UpatedMovieTable();
				break;
			case Table.Genres:
				var addGenreForm = new AddGenreForm();
				addGenreForm.ShowDialog();
				UpatedGenreTable();
				break;
			default:
				MessageBox.Show("Как вы нажали на кнопку?");
				break;
		}
	}

	private void updateButton_Click(object sender, EventArgs e)
	{
		if (mainTable.SelectedRows.Count == 0)
		{
			MessageBox.Show("Нужно выбрать строку которую хотите изменить");
			return;
		}
		var selectedRow = mainTable.SelectedRows[0].Cells;
		switch (table)
		{
			case Table.Movie:
				var movie = new Movie(selectedRow[0].Value.ToString()!, int.Parse(selectedRow[1].Value.ToString()!), TimeSpan.Parse(selectedRow[2].Value.ToString()!), selectedRow[3].Value.ToString(), selectedRow[4].Value.ToString());
				var addForm = new ChangeMovieForm(movie);
				addForm.ShowDialog();
				UpatedMovieTable();
				break;
			case Table.Genres:
				var addGenreForm = new ChangeGenreForm(selectedRow[0].Value.ToString()!);
				addGenreForm.ShowDialog();
				UpatedGenreTable();
				break;
			default:
				MessageBox.Show("Как вы нажали на кнопку?");
				break;
		}
	}

	private void deleteButton_Click(object sender, EventArgs e)
	{
		if (mainTable.SelectedRows.Count == 0)
		{
			MessageBox.Show("Нужно выбрать строку которую хотите удалить");
			return;
		}
		var selectedRow = mainTable.SelectedRows[0].Cells;
		switch (table)
		{
			case Table.Movie:
				var movie = new Movie(selectedRow[0].Value.ToString()!, int.Parse(selectedRow[1].Value.ToString()!), TimeSpan.Parse(selectedRow[2].Value.ToString()!), selectedRow[3].Value.ToString(), selectedRow[4].Value.ToString());
				_movieRepository.Delete(movie);
				UpatedMovieTable();
				break;
			case Table.Genres:
				var result = _genreRepository.Delete(selectedRow[0].Value.ToString()!);
				if (!result.IsSuccess)
				{
					MessageBox.Show("Невозможно удалить жанры, которые привязаны к фильмам.");
					return;
				}
				UpatedGenreTable();
				break;
			default:
				MessageBox.Show("Как вы нажали на кнопку?");
				break;
		}
	}

	private enum Table
	{
		Movie,
		Genres
	}
}
