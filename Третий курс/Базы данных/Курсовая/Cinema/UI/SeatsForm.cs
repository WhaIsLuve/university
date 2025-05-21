using Core.Halls.Repositories;
using Infrastructure.Halls;
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

namespace UI
{
	public partial class SeatsForm : Form
	{
		private readonly IHallRepository _hallRepository;
		public SeatsForm(string hallName)
		{
			InitializeComponent();
			var connectionsStrings = ConnectionStringGetter.ConnectionStrings;
			_hallRepository = new HallRepository(connectionsStrings);
			var dataTable = InitialTable("Ряд", "Номер места");
			var seatsByHall = _hallRepository.GetAllSeatsByHallName(hallName);

			foreach (var seat in seatsByHall)
			{
				dataTable.Rows.Add(seat.Row, seat.SeatNumber);
			}
			seats.DataSource = dataTable;
		}

		private DataTable InitialTable(params string[] columnsName)
		{
			var dataTable = new DataTable();
			foreach (string columnName in columnsName)
			{
				dataTable.Columns.Add(columnName);
			}

			return dataTable;
		}
	}
}
