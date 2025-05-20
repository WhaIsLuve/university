using Core.Genres;
using Core.Genres.Repositories;
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
	public partial class AddGenreForm : Form
	{
		private readonly IGenreRepository _genreRepository;
		public AddGenreForm()
		{
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_genreRepository = new GenreRepository(connectionsStrings);
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Name.Text))
			{
				MessageBox.Show("Наименование не может быть пустым или из пробелов.");
				return;
			}

			var result = _genreRepository.Add(new Genre(Name.Text));
			if(result.IsSuccess)
			{
				Close();
				return;
			}
			MessageBox.Show("Либо что-то пошло не так, либо вы пытаетесь создать жанр с наименованием, которое уже существует.");
		}
	}
}
