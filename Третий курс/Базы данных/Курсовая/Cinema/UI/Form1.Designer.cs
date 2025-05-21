namespace UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			mediaLibrary = new ContextMenuStrip(components);
			фильмыToolStripMenuItem = new ToolStripMenuItem();
			жанрыToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1 = new MenuStrip();
			mediaLibraryToolStripMenuItem = new ToolStripMenuItem();
			moviesToolStripMenuItem1 = new ToolStripMenuItem();
			genresToolStripMenuItem1 = new ToolStripMenuItem();
			расписаниеСеансовToolStripMenuItem = new ToolStripMenuItem();
			кассаToolStripMenuItem = new ToolStripMenuItem();
			hallManagerToolStripMenuItem = new ToolStripMenuItem();
			менюToolStripMenuItem = new ToolStripMenuItem();
			акцииToolStripMenuItem = new ToolStripMenuItem();
			mainTable = new DataGridView();
			createButton = new Button();
			updateAndShowSeatsButton = new Button();
			deleteButton = new Button();
			mediaLibrary.SuspendLayout();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)mainTable).BeginInit();
			SuspendLayout();
			// 
			// mediaLibrary
			// 
			mediaLibrary.AccessibleRole = AccessibleRole.MenuBar;
			mediaLibrary.ImageScalingSize = new Size(20, 20);
			mediaLibrary.Items.AddRange(new ToolStripItem[] { фильмыToolStripMenuItem, жанрыToolStripMenuItem });
			mediaLibrary.Name = "mediaLibrary";
			mediaLibrary.ShowCheckMargin = true;
			mediaLibrary.Size = new Size(159, 52);
			mediaLibrary.Text = "Медиатека";
			// 
			// фильмыToolStripMenuItem
			// 
			фильмыToolStripMenuItem.Name = "фильмыToolStripMenuItem";
			фильмыToolStripMenuItem.Size = new Size(158, 24);
			фильмыToolStripMenuItem.Text = "Фильмы";
			// 
			// жанрыToolStripMenuItem
			// 
			жанрыToolStripMenuItem.Name = "жанрыToolStripMenuItem";
			жанрыToolStripMenuItem.Size = new Size(158, 24);
			жанрыToolStripMenuItem.Text = "Жанры";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { mediaLibraryToolStripMenuItem, расписаниеСеансовToolStripMenuItem, кассаToolStripMenuItem, hallManagerToolStripMenuItem, менюToolStripMenuItem, акцииToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1121, 28);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// mediaLibraryToolStripMenuItem
			// 
			mediaLibraryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moviesToolStripMenuItem1, genresToolStripMenuItem1 });
			mediaLibraryToolStripMenuItem.Name = "mediaLibraryToolStripMenuItem";
			mediaLibraryToolStripMenuItem.Size = new Size(98, 24);
			mediaLibraryToolStripMenuItem.Text = "Медиатека";
			// 
			// moviesToolStripMenuItem1
			// 
			moviesToolStripMenuItem1.Name = "moviesToolStripMenuItem1";
			moviesToolStripMenuItem1.Size = new Size(150, 26);
			moviesToolStripMenuItem1.Text = "Фильмы";
			moviesToolStripMenuItem1.Click += moviesToolStripMenuItem1_Click;
			// 
			// genresToolStripMenuItem1
			// 
			genresToolStripMenuItem1.Name = "genresToolStripMenuItem1";
			genresToolStripMenuItem1.Size = new Size(150, 26);
			genresToolStripMenuItem1.Text = "Жанры";
			genresToolStripMenuItem1.Click += genresToolStripMenuItem1_Click;
			// 
			// расписаниеСеансовToolStripMenuItem
			// 
			расписаниеСеансовToolStripMenuItem.Name = "расписаниеСеансовToolStripMenuItem";
			расписаниеСеансовToolStripMenuItem.Size = new Size(165, 24);
			расписаниеСеансовToolStripMenuItem.Text = "Расписание сеансов";
			// 
			// кассаToolStripMenuItem
			// 
			кассаToolStripMenuItem.Name = "кассаToolStripMenuItem";
			кассаToolStripMenuItem.Size = new Size(62, 24);
			кассаToolStripMenuItem.Text = "Касса";
			// 
			// hallManagerToolStripMenuItem
			// 
			hallManagerToolStripMenuItem.Name = "hallManagerToolStripMenuItem";
			hallManagerToolStripMenuItem.Size = new Size(163, 24);
			hallManagerToolStripMenuItem.Text = "Управление залами";
			hallManagerToolStripMenuItem.Click += hallManagerToolStripMenuItem_Click;
			// 
			// менюToolStripMenuItem
			// 
			менюToolStripMenuItem.Name = "менюToolStripMenuItem";
			менюToolStripMenuItem.Size = new Size(65, 24);
			менюToolStripMenuItem.Text = "Меню";
			менюToolStripMenuItem.Click += menuToolStripMenuItem_Click;
			// 
			// акцииToolStripMenuItem
			// 
			акцииToolStripMenuItem.Name = "акцииToolStripMenuItem";
			акцииToolStripMenuItem.Size = new Size(67, 24);
			акцииToolStripMenuItem.Text = "Акции";
			акцииToolStripMenuItem.Click += promotionToolStripMenuItem_Click;
			// 
			// mainTable
			// 
			mainTable.AllowUserToAddRows = false;
			mainTable.AllowUserToDeleteRows = false;
			mainTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			mainTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			mainTable.BackgroundColor = Color.DarkSlateGray;
			mainTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			mainTable.Dock = DockStyle.Bottom;
			mainTable.Location = new Point(0, 134);
			mainTable.Name = "mainTable";
			mainTable.RowHeadersWidth = 51;
			mainTable.Size = new Size(1121, 466);
			mainTable.TabIndex = 2;
			mainTable.Visible = false;
			// 
			// createButton
			// 
			createButton.Anchor = AnchorStyles.None;
			createButton.Location = new Point(161, 58);
			createButton.Name = "createButton";
			createButton.Size = new Size(173, 46);
			createButton.TabIndex = 3;
			createButton.Text = "Создать";
			createButton.UseVisualStyleBackColor = true;
			createButton.Visible = false;
			createButton.Click += createButton_Click;
			// 
			// updateAndShowSeatsButton
			// 
			updateAndShowSeatsButton.Anchor = AnchorStyles.None;
			updateAndShowSeatsButton.Location = new Point(447, 58);
			updateAndShowSeatsButton.Name = "updateAndShowSeatsButton";
			updateAndShowSeatsButton.Size = new Size(170, 46);
			updateAndShowSeatsButton.TabIndex = 4;
			updateAndShowSeatsButton.Text = "Изменить";
			updateAndShowSeatsButton.UseVisualStyleBackColor = true;
			updateAndShowSeatsButton.Visible = false;
			updateAndShowSeatsButton.Click += updateButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Anchor = AnchorStyles.None;
			deleteButton.Location = new Point(691, 58);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(170, 46);
			deleteButton.TabIndex = 5;
			deleteButton.Text = "Удалить";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Visible = false;
			deleteButton.Click += deleteButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Teal;
			ClientSize = new Size(1121, 600);
			Controls.Add(deleteButton);
			Controls.Add(updateAndShowSeatsButton);
			Controls.Add(createButton);
			Controls.Add(mainTable);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			mediaLibrary.ResumeLayout(false);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)mainTable).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ToolStripMenuItem фильмыToolStripMenuItem;
		private ToolStripMenuItem жанрыToolStripMenuItem;
		public ContextMenuStrip mediaLibrary;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem mediaLibraryToolStripMenuItem;
		private ToolStripMenuItem moviesToolStripMenuItem1;
		private ToolStripMenuItem genresToolStripMenuItem1;
		private ToolStripMenuItem расписаниеСеансовToolStripMenuItem;
		private ToolStripMenuItem кассаToolStripMenuItem;
		private ToolStripMenuItem hallManagerToolStripMenuItem;
		private ToolStripMenuItem менюToolStripMenuItem;
		private ToolStripMenuItem акцииToolStripMenuItem;
		private DataGridView mainTable;
		private Button createButton;
		private Button updateAndShowSeatsButton;
		private Button deleteButton;
	}
}
