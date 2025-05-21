using Core.Screenings;
using Core.Screenings.Repositories;
using Infrastructure.Options;
using Infrastructure.Screenings;
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
	public partial class ChangeScreeningForm : Form
	{
		private readonly IScreeningRepository _screeningRepository;
		private Screening _oldData;

		public ChangeScreeningForm(Screening screening)
		{
			InitializeComponent();
			_oldData = screening;
			textBox1.Text = screening.Price.ToString();
			dateTimePicker1.Value = screening.StartDateTime;
			dateTimePicker2.Value = screening.EndDateTime;
			var connectionStrings = ConnectionStringGetter.ConnectionStrings;
			_screeningRepository = new ScreeningRepository(connectionStrings);
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
			var screening = new Screening(_oldData.Id, _oldData.MovieName, _oldData.HallName, result, dateTimePicker1.Value, dateTimePicker2.Value);
			_screeningRepository.Update(screening);
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
