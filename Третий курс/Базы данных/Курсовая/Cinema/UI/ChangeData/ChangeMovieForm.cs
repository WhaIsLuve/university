using Core.Genres.Repositories;
using Core.Movies;
using Core.Movies.Repositories;
using Infrastructure.Genres;
using Infrastructure.Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Helpers;

namespace UI.ChangeData
{
	public partial class ChangeMovieForm : Form
	{
		private readonly Movie _oldData;
		private readonly IMovieRepository _movieRepository;
		private readonly IGenreRepository _genreRepository;

		public ChangeMovieForm(Movie movie)
		{
			InitializeComponent();
			Name.Text = movie.DisplayName;
			textBox1.Text = movie.Country;
			textBox2.Text = movie.Duration.ToString();
			comboBox1.SelectedItem = movie.Rating.ToString();
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_movieRepository = new MovieRepository(connectionsStrings);
			_genreRepository = new GenreRepository(connectionsStrings);
			genres.Items.Clear();
			genres.Items.AddRange(_genreRepository.GetGenres().Select(g => g.DisplayName).ToArray());
			genres.SelectedItem = movie.Genres;
			_oldData = new Movie(movie.DisplayName, movie.Rating, movie.Duration, movie.Country, movie.Genres);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Данные кроме страны и жанров не могут быть пустыми.");
				return;
			}
			var genre = genres.SelectedItem?.ToString() ?? string.Empty;
			var rating = int.Parse(comboBox1.SelectedItem!.ToString()!);
			var movie = new Movie(Name.Text, rating, TimeSpan.Parse(textBox2.Text), textBox1.Text, genre);
			var result = _movieRepository.Update(_oldData, movie);
			if(result.IsSuccess)
			{
				Close();
				return;
			}
			MessageBox.Show("Чтобы изменить фильм нужно, чтобы хотя один параметр был уникален.");

		}
	}
}
