using Core.MenuItems;
using Core.MenuItems.Repositories;
using Infrastructure.MenuItems;
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

namespace UI.ChangeData
{
	public partial class ChangeMenuItemForm : Form
	{
		private MenuItem _oldData;
		private IMenuItemRepository _menuItemRepository;

		public ChangeMenuItemForm(MenuItem menuItem)
		{
			InitializeComponent();
			_oldData = menuItem;
			Name.Text = menuItem.DisplayName;
			Price.Text = menuItem.Price.ToString();
			checkBox1.Checked = menuItem.IsAvailable;
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_menuItemRepository = new MenuItemRepository(connectionsStrings);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Name.Text) || string.IsNullOrWhiteSpace(Price.Text))
			{
				MessageBox.Show("Данные не могут быть пустыми.");
				return;
			}
			if (!int.TryParse(Price.Text, out var result))
			{
				MessageBox.Show("Цена должна быть числом.");
				return;
			}
			var menuItem = new MenuItem(Name.Text, result, checkBox1.Checked);
			var res = _menuItemRepository.Update(_oldData.DisplayName, menuItem);
			if (!res.IsSuccess)
			{
				MessageBox.Show("Либо что-то произошло, либо вы пытаетесь изменить продукт на тот, который уже существует.");
				return;
			}
			Close();
		}
	}
}
