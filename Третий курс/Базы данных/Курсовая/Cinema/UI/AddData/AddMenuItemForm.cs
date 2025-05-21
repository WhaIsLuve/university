using Core.Halls.Repositories;
using Core.Halls;
using Core.MenuItems.Repositories;
using Infrastructure.Halls;
using Infrastructure.MenuItems;
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
using Core.MenuItems;

namespace UI.AddData
{
	public partial class AddMenuItemForm : Form
	{
		private IMenuItemRepository _menuItemRepository;

		public AddMenuItemForm()
		{
			InitializeComponent();
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_menuItemRepository = new MenuItemRepository(connectionsStrings);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(price.Text))
			{
				MessageBox.Show("Данные не могут быть пустыми.");
				return;
			}
			if (!int.TryParse(price.Text, out var result))
			{
				MessageBox.Show("Цена должна быть числом.");
				return;
			}
			var menuItem = new MenuItem(Name.Text, result);
			var res = _menuItemRepository.Add(menuItem);
			if (!res.IsSuccess)
			{
				MessageBox.Show("Либо что-то произошло, либо вы пытаетесь создать продукт, который уже существует.");
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
