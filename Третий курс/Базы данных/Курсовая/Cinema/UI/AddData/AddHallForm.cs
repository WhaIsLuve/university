using Core.Genres;
using Core.Halls;
using Core.Halls.Repositories;
using Core.Movies;
using Infrastructure.Halls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.AddData
{
	public partial class AddHallForm : Form
	{
		private readonly IHallRepository _hallRepository;

		public AddHallForm()
		{
			InitializeComponent();
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_hallRepository = new HallRepository(connectionsStrings);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(capacity.Text))
			{
				MessageBox.Show("Данные не могут быть пустыми.");
				return;
			}
			if (!int.TryParse(capacity.Text, out var result))
			{
				MessageBox.Show("Вместимость должно быть числом.");
				return;
			}
			var hall = new Hall(Name.Text, result);
			var res = _hallRepository.Add(hall);
			if(!res.IsSuccess)
			{
				MessageBox.Show("Либо что-то произошло, либо вы пытаетесь создать зал, который уже существует.");
				return;
			}
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
