namespace UI.ChangeData
{
	partial class ChangeScreeningForm
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
			label5 = new Label();
			dateTimePicker2 = new DateTimePicker();
			label4 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label3 = new Label();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(157, 202);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 21;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(257, 202);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 20;
			button1.Text = "Обновить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 119);
			label5.Name = "label5";
			label5.Size = new Size(139, 20);
			label5.TabIndex = 19;
			label5.Text = "Дата конца показа";
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(12, 142);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(280, 27);
			dateTimePicker2.TabIndex = 18;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 60);
			label4.Name = "label4";
			label4.Size = new Size(93, 20);
			label4.TabIndex = 17;
			label4.Text = "Дата показа";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 83);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(280, 27);
			dateTimePicker1.TabIndex = 16;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 9);
			label3.Name = "label3";
			label3.Size = new Size(83, 20);
			label3.TabIndex = 15;
			label3.Text = "Стоимость";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 30);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 14;
			// 
			// ChangeScreeningForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(360, 246);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(dateTimePicker2);
			Controls.Add(label4);
			Controls.Add(dateTimePicker1);
			Controls.Add(label3);
			Controls.Add(textBox1);
			MaximumSize = new Size(378, 293);
			MinimumSize = new Size(378, 293);
			Name = "ChangeScreeningForm";
			Text = "ChangeScreeningForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private Label label5;
		private DateTimePicker dateTimePicker2;
		private Label label4;
		private DateTimePicker dateTimePicker1;
		private Label label3;
		private TextBox textBox1;
	}
}