namespace UI
{
	partial class CassaForm
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
			comboBox1 = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			comboBox2 = new ComboBox();
			label3 = new Label();
			comboBox3 = new ComboBox();
			label4 = new Label();
			comboBox4 = new ComboBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(31, 56);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(557, 28);
			comboBox1.TabIndex = 0;
			comboBox1.SelectedIndexChanged += change_movie;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(31, 20);
			label1.Name = "label1";
			label1.Size = new Size(107, 20);
			label1.TabIndex = 1;
			label1.Text = "Фильмы и зал";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(31, 93);
			label2.Name = "label2";
			label2.Size = new Size(49, 20);
			label2.TabIndex = 3;
			label2.Text = "Билет";
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(31, 129);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(557, 28);
			comboBox2.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(31, 163);
			label3.Name = "label3";
			label3.Size = new Size(51, 20);
			label3.TabIndex = 5;
			label3.Text = "Меню";
			// 
			// comboBox3
			// 
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(31, 199);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(557, 28);
			comboBox3.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(31, 232);
			label4.Name = "label4";
			label4.Size = new Size(57, 20);
			label4.TabIndex = 7;
			label4.Text = "Скидка";
			// 
			// comboBox4
			// 
			comboBox4.FormattingEnabled = true;
			comboBox4.Location = new Point(31, 268);
			comboBox4.Name = "comboBox4";
			comboBox4.Size = new Size(557, 28);
			comboBox4.TabIndex = 6;
			// 
			// button1
			// 
			button1.Location = new Point(198, 323);
			button1.Name = "button1";
			button1.Size = new Size(240, 29);
			button1.TabIndex = 8;
			button1.Text = "Бронировать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// CassaForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(634, 376);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(comboBox4);
			Controls.Add(label3);
			Controls.Add(comboBox3);
			Controls.Add(label2);
			Controls.Add(comboBox2);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			Name = "CassaForm";
			Text = "CassaForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBox1;
		private Label label1;
		private Label label2;
		private ComboBox comboBox2;
		private Label label3;
		private ComboBox comboBox3;
		private Label label4;
		private ComboBox comboBox4;
		private Button button1;
	}
}