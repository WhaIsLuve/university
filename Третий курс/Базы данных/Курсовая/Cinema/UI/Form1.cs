using Core.Genres.Repositories;
using Core.Halls.Repositories;
using Core.MenuItems;
using Core.MenuItems.Repositories;
using Core.Movies;
using Core.Movies.Repositories;
using Core.Promotions.Repositories;
using Core.Screenings;
using Core.Screenings.Repositories;
using Infrastructure.Genres;
using Infrastructure.Halls;
using Infrastructure.MenuItems;
using Infrastructure.Movies;
using Infrastructure.Promotions;
using Infrastructure.Screenings;
using System.Data;
using UI.AddData;
using UI.ChangeData;
using UI.Helpers;

namespace UI;

public partial class Form1 : Form
{
	private readonly IMovieRepository _movieRepository;
	private readonly IGenreRepository _genreRepository;
	private readonly IHallRepository _hallRepository;
	private readonly IMenuItemRepository _menuItemRepository;
	private readonly IPromotionRepository _promotionRepository;
	private readonly IScreeningRepository _screeningRepository;
	private IEnumerable<Screening> _screenings;
	private Table? _table;

	public Form1()
	{
		InitializeComponent();
		var connectionStrings = ConnectionStringGetter.ConnectionStrings;
		_movieRepository = new MovieRepository(connectionStrings);
		_genreRepository = new GenreRepository(connectionStrings);
		_hallRepository = new HallRepository(connectionStrings);
		_menuItemRepository = new MenuItemRepository(connectionStrings);
		_promotionRepository = new PromotionRepository(connectionStrings);
		_screeningRepository = new ScreeningRepository(connectionStrings);
	}

	private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateAndShowSeatsButton.Visible = true;
		updateAndShowSeatsButton.Text = "Изменить";
		deleteButton.Visible = true;
		_table = Table.Movie;
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

	private void UpatedHallsTable()
	{
		var dataTable = InitialTable("Наименование", "Вместимость");
		var halls = _hallRepository.GetHalls();
		foreach (var hall in halls)
		{
			dataTable.Rows.Add(hall.DisplayName, hall.Capacity);
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
		updateAndShowSeatsButton.Visible = true;
		updateAndShowSeatsButton.Text = "Изменить";
		deleteButton.Visible = true;
		_table = Table.Genres;
		UpatedGenreTable();
	}

	private void createButton_Click(object sender, EventArgs e)
	{
		switch (_table)
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
			case Table.HallManager:
				var addHallForm = new AddHallForm();
				addHallForm.ShowDialog();
				UpatedHallsTable();
				break;
			case Table.Menu:
				var addMenuForm = new AddMenuItemForm();
				addMenuForm.ShowDialog();
				UpatedMenuTable();
				break;
			case Table.Promotions:
				var addPromForm = new AddPromotionForm();
				addPromForm.ShowDialog();
				UpatedPromotionTable();
				break;
			case Table.Screening:
				var addScr = new AddScreeningForm();
				addScr.ShowDialog();
				UpatedScreeningTable();
				break;
			default:
				MessageBox.Show("Как вы нажали на кнопку?");
				break;
		}
	}

	private void updateButton_Click(object sender, EventArgs e)
	{
		if (mainTable.SelectedRows.Count == 0 && _table == Table.HallManager)
		{
			MessageBox.Show("Нужно выбрать строку, чтобы посмотреть места у зала.");
			return;
		}
		if (mainTable.SelectedRows.Count == 0)
		{
			MessageBox.Show("Нужно выбрать строку которую хотите изменить.");
			return;
		}
		var selectedRow = mainTable.SelectedRows[0].Cells;
		switch (_table)
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
			case Table.HallManager:
				new SeatsForm(selectedRow[0].Value.ToString()!).ShowDialog();
				break;
			case Table.Menu:
				var menu = new MenuItem(selectedRow[0].Value.ToString()!, int.Parse(selectedRow[1].Value.ToString()!), bool.Parse(selectedRow[2].Value.ToString()!));
				var addMenuForm = new ChangeMenuItemForm(menu);
				addMenuForm.ShowDialog();
				UpatedMenuTable();
				break;
			case Table.Screening:
				var scr = _screenings.First(s => s.MovieName == selectedRow[0].Value.ToString()! && s.HallName == selectedRow[1].Value.ToString()!);
				var form = new ChangeScreeningForm(scr);
				form.ShowDialog();
				UpatedScreeningTable();
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
		switch (_table)
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
			case Table.HallManager:
				_hallRepository.Delete(selectedRow[0].Value.ToString()!);
				UpatedHallsTable();
				break;
			case Table.Menu:
				_menuItemRepository.Delete(selectedRow[0].Value.ToString()!);
				UpatedMenuTable();
				break;
			case Table.Promotions:
				_promotionRepository.Delete(selectedRow[0].Value.ToString()!);
				UpatedPromotionTable();
				break;
			case Table.Screening:
				_screeningRepository.Delete(_screenings.First(s => s.MovieName == selectedRow[0].Value.ToString()! && s.HallName == selectedRow[1].Value.ToString()!));
				UpatedScreeningTable();
				break;
			default:
				MessageBox.Show("Как вы нажали на кнопку?");
				break;
		}
	}

	private void hallManagerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateAndShowSeatsButton.Visible = true;
		updateAndShowSeatsButton.Text = "Места у зала";
		deleteButton.Visible = true;
		_table = Table.HallManager;
		UpatedHallsTable();
	}

	private void menuToolStripMenuItem_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateAndShowSeatsButton.Visible = true;
		updateAndShowSeatsButton.Text = "Изменить";
		deleteButton.Visible = true;
		_table = Table.Menu;
		UpatedMenuTable();
	}

	private void UpatedMenuTable()
	{
		var dataTable = InitialTable("Наименование", "Цена", "Наличие");
		var menuItems = _menuItemRepository.GetMenuItems();
		foreach (var menuItem in menuItems)
		{
			dataTable.Rows.Add(menuItem.DisplayName, menuItem.Price, menuItem.IsAvailable);
		}
		mainTable.DataSource = dataTable;
	}

	private void UpatedPromotionTable()
	{
		var dataTable = InitialTable("Наименование", "Процент скидки", "Начало скидки", "Конец скидки");
		var promotions = _promotionRepository.GetPromotions();
		foreach (var promotion in promotions)
		{
			dataTable.Rows.Add(promotion.DisplayName, promotion.DiscountPercent, promotion.StartDateTime, promotion.EndDateTime);
		}
		mainTable.DataSource = dataTable;
	}

	private void promotionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateAndShowSeatsButton.Visible = false;
		deleteButton.Visible = true;
		_table = Table.Promotions;
		UpatedPromotionTable();
	}

	private void screeningToolStripMenuItem_Click(object sender, EventArgs e)
	{
		mainTable.Visible = true;
		createButton.Visible = true;
		updateAndShowSeatsButton.Visible = true;
		updateAndShowSeatsButton.Text = "Изменить";
		deleteButton.Visible = true;
		_table = Table.Screening;
		UpatedScreeningTable();
	}

	private void UpatedScreeningTable()
	{
		var dataTable = InitialTable("Фильм", "Зал", "Стоимость", "Дата начало", "Дата конец");
		_screenings = _screeningRepository.GetScreenings();

		foreach (var screening in _screenings)
		{
			dataTable.Rows.Add(screening.MovieName, screening.HallName, screening.Price, screening.StartDateTime, screening.EndDateTime);
		}
		mainTable.DataSource = dataTable;
	}

	private enum Table
	{
		Movie,
		Genres,
		HallManager,
		Menu,
		Promotions,
		Screening
	}
}
