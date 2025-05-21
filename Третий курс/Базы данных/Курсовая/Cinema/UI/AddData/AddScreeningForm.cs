using Core.Screenings;
using Core.Screenings.Repositories;
using Infrastructure.Halls;
using Infrastructure.MenuItems;
using Infrastructure.Movies;
using Infrastructure.Options;
using Infrastructure.Promotions;
using Infrastructure.Screenings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.AddData
{
	public partial class AddScreeningForm : Form
	{
		private readonly IScreeningRepository _screeningRepository;
		public AddScreeningForm()
		{
			InitializeComponent();
			var connectionStrings = ConnectionStringGetter.ConnectionStrings;
			var _hallRepository = new HallRepository(connectionStrings);
			var _movieRepository = new MovieRepository(connectionStrings);
			_screeningRepository = new ScreeningRepository(connectionStrings);
			comboBox1.Items.AddRange(_movieRepository.GetMovies().Select(m => m.DisplayName).ToArray());
			comboBox2.Items.AddRange(_hallRepository.GetHalls().Select(h => h.DisplayName).ToArray());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Цена не должна быть пустой.");
				return;
			}
			if (!int.TryParse(textBox1.Text, out var result))
			{
				MessageBox.Show("Цена должна быть числом.");
				return;
			}
			var screening = new Screening(0, comboBox1.SelectedItem!.ToString()!, comboBox2.SelectedItem!.ToString()!, result, dateTimePicker1.Value, dateTimePicker2.Value);
			_screeningRepository.Add(screening);
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
