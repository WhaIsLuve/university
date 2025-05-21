namespace UI.AddData
{
	partial class AddPromotionForm
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
			Name = new TextBox();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label3 = new Label();
			label4 = new Label();
			dateTimePicker2 = new DateTimePicker();
			button2 = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// Name
			// 
			Name.Location = new Point(12, 45);
			Name.Name = "Name";
			Name.Size = new Size(364, 27);
			Name.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 22);
			label1.Name = "label1";
			label1.Size = new Size(116, 20);
			label1.TabIndex = 1;
			label1.Text = "Наименование";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 113);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(179, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 90);
			label2.Name = "label2";
			label2.Size = new Size(121, 20);
			label2.TabIndex = 3;
			label2.Text = "Процент скидки";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 174);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(250, 27);
			dateTimePicker1.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 151);
			label3.Name = "label3";
			label3.Size = new Size(94, 20);
			label3.TabIndex = 5;
			label3.Text = "Дата начала";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 215);
			label4.Name = "label4";
			label4.Size = new Size(121, 20);
			label4.TabIndex = 7;
			label4.Text = "Дата окончания";
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(12, 238);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(250, 27);
			dateTimePicker2.TabIndex = 6;
			// 
			// button2
			// 
			button2.Location = new Point(182, 357);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 13;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(282, 357);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 12;
			button1.Text = "Создать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// AddPromotionForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(388, 398);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(dateTimePicker2);
			Controls.Add(label3);
			Controls.Add(dateTimePicker1);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(Name);
			MaximumSize = new Size(406, 445);
			MinimumSize = new Size(406, 445);
			Text = "AddPromotionForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox Name;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private DateTimePicker dateTimePicker1;
		private Label label3;
		private Label label4;
		private DateTimePicker dateTimePicker2;
		private Button button2;
		private Button button1;
	}
}