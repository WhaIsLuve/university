using Core.Genres.Repositories;
using Core.Halls.Repositories;
using Core.MenuItems.Repositories;
using Core.Movies.Repositories;
using Core.Promotions.Repositories;
using Core.Screenings.Repositories;
using Core.Screenings;
using Infrastructure.Genres;
using Infrastructure.Halls;
using Infrastructure.MenuItems;
using Infrastructure.Movies;
using Infrastructure.Promotions;
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
using Core.Purchases.Repositories;
using Infrastructure.Purchases;
using Core.Purchases;

namespace UI
{
	public partial class CassaForm : Form
	{
		private readonly IMovieRepository _movieRepository;
		private readonly IHallRepository _hallRepository;
		private readonly IMenuItemRepository _menuItemRepository;
		private readonly IPromotionRepository _promotionRepository;
		private readonly IScreeningRepository _screeningRepository;
		private readonly IPurchaseRepository _purchaseRepository;
		private IEnumerable<Screening> _screenings;
		private IEnumerable<(int Row, int SeatNumber, int TicketId)> values;

		public CassaForm()
		{
			InitializeComponent();
			Text = "Касса";
			var connectionStrings = ConnectionStringGetter.ConnectionStrings;
			_movieRepository = new MovieRepository(connectionStrings);
			_hallRepository = new HallRepository(connectionStrings);
			_menuItemRepository = new MenuItemRepository(connectionStrings);
			_promotionRepository = new PromotionRepository(connectionStrings);
			_screeningRepository = new ScreeningRepository(connectionStrings);
			_purchaseRepository = new PurchaseRepository(connectionStrings);
			_screenings = _screeningRepository.GetScreenings();
			comboBox1.Items.AddRange(_screenings.Select(s => $"{s.MovieName} {s.HallName}").ToArray());
			comboBox3.Items.AddRange(_menuItemRepository.GetMenuItems().Select(m => m.DisplayName).ToArray());
			comboBox4.Items.AddRange(_promotionRepository.GetPromotions().Select(p => p.DisplayName).ToArray());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var menuName = comboBox3.SelectedItem as string;
			var promotion = comboBox4.SelectedItem as string;
			var ticketId = values.First(v => $"{v.Row} Ряд {v.SeatNumber} место" == comboBox2.SelectedItem!.ToString()).TicketId;
			var totalPrice = _purchaseRepository.Add(new Purchase(ticketId, menuName, promotion));
			MessageBox.Show($"Итоговая цена: {totalPrice}");
			Close();
		}

		private void change_movie(object sender, EventArgs e)
		{
			// Get tickets
			comboBox2.Items.Clear();
			var id = _screenings.First(s => $"{s.MovieName} {s.HallName}" == comboBox1.SelectedItem!.ToString()).Id;
			values = _screeningRepository.GetSeatTickets(id);
			comboBox2.Items.AddRange(values.Select(s => $"{s.Row} Ряд {s.SeatNumber} место").ToArray());
		}
	}
}
