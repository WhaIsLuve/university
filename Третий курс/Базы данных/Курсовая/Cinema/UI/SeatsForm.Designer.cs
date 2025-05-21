namespace UI
{
	partial class SeatsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			seats = new DataGridView();
			((System.ComponentModel.ISupportInitialize)seats).BeginInit();
			SuspendLayout();
			// 
			// seats
			// 
			seats.AllowUserToAddRows = false;
			seats.AllowUserToDeleteRows = false;
			seats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			seats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			seats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			seats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			seats.Location = new Point(-5, -2);
			seats.Name = "seats";
			seats.ReadOnly = true;
			seats.RowHeadersWidth = 51;
			seats.Size = new Size(404, 445);
			seats.TabIndex = 0;
			// 
			// SeatsForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(400, 444);
			Controls.Add(seats);
			MaximumSize = new Size(418, 491);
			MinimumSize = new Size(418, 491);
			Name = "SeatsForm";
			Text = "SeatsForm";
			((System.ComponentModel.ISupportInitialize)seats).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView seats;
	}
}