namespace UI.AddData
{
	partial class AddGenreForm
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
			label1 = new Label();
			Name = new TextBox();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(147, 134);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 13;
			button2.Text = "Отмена";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(247, 134);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 12;
			button1.Text = "Создать";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 21);
			label1.Name = "label1";
			label1.Size = new Size(116, 20);
			label1.TabIndex = 15;
			label1.Text = "Наименование";
			// 
			// Name
			// 
			Name.Location = new Point(16, 59);
			Name.Name = "Name";
			Name.Size = new Size(325, 27);
			Name.TabIndex = 14;
			// 
			// AddGenreForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(353, 175);
			Controls.Add(label1);
			Controls.Add(Name);
			Controls.Add(button2);
			Controls.Add(button1);
			MaximumSize = new Size(371, 222);
			MinimumSize = new Size(371, 222);
			Text = "Добавить жанр";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private Label label1;
		private TextBox Name;
	}
}