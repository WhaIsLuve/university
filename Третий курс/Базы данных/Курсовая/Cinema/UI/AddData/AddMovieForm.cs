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

namespace UI.AddData
{
	public partial class AddMovieForm : Form
	{
		private readonly IMovieRepository _movieRepository;
		private readonly IGenreRepository _genreRepository;

		public AddMovieForm()
		{
			InitializeComponent();
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_movieRepository = new MovieRepository(connectionsStrings);
			_genreRepository = new GenreRepository(connectionsStrings);
			genres.Items.Clear();
			genres.Items.AddRange(_genreRepository.GetGenres().Select(g => g.DisplayName).ToArray());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Данные кроме страны и жанров не могут быть пустыми.");
				return;
			}
			var genre = genres.SelectedItem?.ToString() ?? string.Empty;
			var rating = int.Parse(comboBox1.SelectedItem!.ToString()!);
			var movie = new Movie(Name.Text, rating, TimeSpan.Parse(textBox2.Text), textBox1.Text, genre);
			_movieRepository.Add(movie);
			Close();
		}
	}
}
