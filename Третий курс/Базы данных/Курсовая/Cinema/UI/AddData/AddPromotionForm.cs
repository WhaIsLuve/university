using Core.MenuItems;
using Core.Promotions;
using Core.Promotions.Repositories;
using Infrastructure.Promotions;
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

namespace UI.AddData
{
	public partial class AddPromotionForm : Form
	{
		private readonly IPromotionRepository _promotionRepository;

		public AddPromotionForm()
		{
			InitializeComponent();
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_promotionRepository = new PromotionRepository(connectionsStrings);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Данные не могут быть пустыми.");
				return;
			}
			if (!int.TryParse(textBox1.Text, out var result) && (result > 100 || result < 0))
			{
				MessageBox.Show("Цена должна быть числом и меньше 100 и больше 0.");
				return;
			}
			var promotion = new Promotion(Name.Text, result, dateTimePicker1.Value, dateTimePicker2.Value);
			var res = _promotionRepository.Add(promotion);
			if (!res.IsSuccess)
			{
				MessageBox.Show("Либо что-то произошло, либо вы пытаетесь создать скидку, которая уже существует.");
				return;
			}
			Close();
		}
	}
}
