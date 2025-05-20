namespace UI.ChangeData
{
	partial class ChangeMovieForm
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
			button2 = new Button();
			button1 = new Button();
			label4 = new Label();
			label3 = new Label();
			genres = new ComboBox();
			comboBox1 = new ComboBox();
			textBox2 = new TextBox();
			label2 = new Label();
			Country = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			Name = new TextBox();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(182, 356);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 23;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(282, 356);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 22;
			button1.Text = "Обновить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(17, 278);
			label4.Name = "label4";
			label4.Size = new Size(48, 20);
			label4.TabIndex = 21;
			label4.Text = "Жанр";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(17, 224);
			label3.Name = "label3";
			label3.Size = new Size(151, 20);
			label3.TabIndex = 20;
			label3.Text = "Возрастной рейтинг";
			// 
			// genres
			// 
			genres.FormattingEnabled = true;
			genres.Location = new Point(12, 308);
			genres.Name = "genres";
			genres.Size = new Size(151, 28);
			genres.TabIndex = 19;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "0", "6", "12", "16", "18" });
			comboBox1.Location = new Point(12, 247);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(167, 28);
			comboBox1.TabIndex = 18;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(12, 181);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(127, 27);
			textBox2.TabIndex = 17;
			textBox2.Text = "00:00:00";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 147);
			label2.Name = "label2";
			label2.Size = new Size(105, 20);
			label2.TabIndex = 16;
			label2.Text = "Длительность";
			// 
			// Country
			// 
			Country.AutoSize = true;
			Country.Location = new Point(17, 81);
			Country.Name = "Country";
			Country.Size = new Size(58, 20);
			Country.TabIndex = 15;
			Country.Text = "Страна";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 108);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(364, 27);
			textBox1.TabIndex = 14;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 13);
			label1.Name = "label1";
			label1.Size = new Size(116, 20);
			label1.TabIndex = 13;
			label1.Text = "Наименование";
			// 
			// Name
			// 
			Name.Location = new Point(12, 43);
			Name.Name = "Name";
			Name.Size = new Size(364, 27);
			Name.TabIndex = 12;
			// 
			// ChangeMovieForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(388, 398);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(genres);
			Controls.Add(comboBox1);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(Country);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(Name);
			MaximumSize = new Size(406, 445);
			MinimumSize = new Size(406, 445);
			Text = "ChangeMovieForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private Label label4;
		private Label label3;
		private ComboBox genres;
		private ComboBox comboBox1;
		private TextBox textBox2;
		private Label label2;
		private Label Country;
		private TextBox textBox1;
		private Label label1;
		private TextBox Name;
	}
}