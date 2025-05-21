namespace UI.ChangeData
{
	partial class ChangeMenuItemForm
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
			label2 = new Label();
			Price = new TextBox();
			label1 = new Label();
			Name = new TextBox();
			button2 = new Button();
			button1 = new Button();
			checkBox1 = new CheckBox();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 89);
			label2.Name = "label2";
			label2.Size = new Size(45, 20);
			label2.TabIndex = 33;
			label2.Text = "Цена";
			// 
			// Price
			// 
			Price.Location = new Point(16, 112);
			Price.Name = "Price";
			Price.Size = new Size(125, 27);
			Price.TabIndex = 32;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 21);
			label1.Name = "label1";
			label1.Size = new Size(116, 20);
			label1.TabIndex = 31;
			label1.Text = "Наименование";
			// 
			// Name
			// 
			Name.Location = new Point(16, 59);
			Name.Name = "Name";
			Name.Size = new Size(325, 27);
			Name.TabIndex = 30;
			// 
			// button2
			// 
			button2.Location = new Point(147, 182);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 29;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(247, 182);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 28;
			button1.Text = "Обновить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// checkBox1
			// 
			checkBox1.AutoSize = true;
			checkBox1.Location = new Point(16, 160);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new Size(104, 24);
			checkBox1.TabIndex = 34;
			checkBox1.Text = "В наличии";
			checkBox1.UseVisualStyleBackColor = true;
			// 
			// ChangeMenuItemForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(353, 223);
			Controls.Add(checkBox1);
			Controls.Add(label2);
			Controls.Add(Price);
			Controls.Add(label1);
			Controls.Add(Name);
			Controls.Add(button2);
			Controls.Add(button1);
			Text = "ChangeMenuItemForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private TextBox Price;
		private Label label1;
		private TextBox Name;
		private Button button2;
		private Button button1;
		private CheckBox checkBox1;
	}
}