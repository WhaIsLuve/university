namespace UI.AddData
{
	partial class AddScreeningForm
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
			textBox1 = new TextBox();
			label3 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label4 = new Label();
			label5 = new Label();
			dateTimePicker2 = new DateTimePicker();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(22, 35);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(346, 28);
			comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 10);
			label1.Name = "label1";
			label1.Size = new Size(56, 20);
			label1.TabIndex = 1;
			label1.Text = "Фильм";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(29, 74);
			label2.Name = "label2";
			label2.Size = new Size(33, 20);
			label2.TabIndex = 3;
			label2.Text = "Зал";
			// 
			// comboBox2
			// 
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(22, 99);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(346, 28);
			comboBox2.TabIndex = 2;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(29, 156);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 135);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 5;
			label3.Text = "Стоимость";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(29, 209);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(280, 27);
			dateTimePicker1.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(29, 186);
			label4.Name = "label4";
			label4.Size = new Size(93, 20);
			label4.TabIndex = 7;
			label4.Text = "Дата показа";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(29, 245);
			label5.Name = "label5";
			label5.Size = new Size(139, 20);
			label5.TabIndex = 9;
			label5.Text = "Дата конца показа";
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(29, 268);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(280, 27);
			dateTimePicker2.TabIndex = 8;
			// 
			// button2
			// 
			button2.Location = new Point(174, 328);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 13;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(274, 328);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 12;
			button1.Text = "Создать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// AddScreeningForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(380, 363);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(dateTimePicker2);
			Controls.Add(label4);
			Controls.Add(dateTimePicker1);
			Controls.Add(label3);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(comboBox2);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			MaximumSize = new Size(398, 410);
			MinimumSize = new Size(398, 410);
			Name = "AddScreeningForm";
			Text = "AddScreeningForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox comboBox1;
		private Label label1;
		private Label label2;
		private ComboBox comboBox2;
		private TextBox textBox1;
		private Label label3;
		private DateTimePicker dateTimePicker1;
		private Label label4;
		private Label label5;
		private DateTimePicker dateTimePicker2;
		private Button button2;
		private Button button1;
	}
}