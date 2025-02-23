namespace WorkWithDb
{
	partial class AddDataForm
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
			AddStudent = new Button();
			Cancel = new Button();
			lastNameInput = new TextBox();
			mathMarkInput = new TextBox();
			csMarkInput = new TextBox();
			englishMarkInput = new TextBox();
			birthdayPicker = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			SuspendLayout();
			// 
			// AddStudent
			// 
			AddStudent.Location = new Point(277, 296);
			AddStudent.Name = "AddStudent";
			AddStudent.Size = new Size(94, 29);
			AddStudent.TabIndex = 0;
			AddStudent.Text = "Добавить";
			AddStudent.UseVisualStyleBackColor = true;
			AddStudent.Click += AddStudent_Click;
			// 
			// Cancel
			// 
			Cancel.Location = new Point(177, 296);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(94, 29);
			Cancel.TabIndex = 1;
			Cancel.Text = "Отмена";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// lastNameInput
			// 
			lastNameInput.Location = new Point(21, 34);
			lastNameInput.Name = "lastNameInput";
			lastNameInput.Size = new Size(290, 27);
			lastNameInput.TabIndex = 2;
			// 
			// mathMarkInput
			// 
			mathMarkInput.Location = new Point(21, 173);
			mathMarkInput.Name = "mathMarkInput";
			mathMarkInput.Size = new Size(36, 27);
			mathMarkInput.TabIndex = 3;
			// 
			// csMarkInput
			// 
			csMarkInput.Location = new Point(121, 173);
			csMarkInput.Name = "csMarkInput";
			csMarkInput.Size = new Size(36, 27);
			csMarkInput.TabIndex = 4;
			// 
			// englishMarkInput
			// 
			englishMarkInput.Location = new Point(235, 173);
			englishMarkInput.Name = "englishMarkInput";
			englishMarkInput.Size = new Size(36, 27);
			englishMarkInput.TabIndex = 5;
			// 
			// birthdayPicker
			// 
			birthdayPicker.Location = new Point(21, 87);
			birthdayPicker.Name = "birthdayPicker";
			birthdayPicker.Size = new Size(250, 27);
			birthdayPicker.TabIndex = 6;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 126);
			label1.Name = "label1";
			label1.Size = new Size(135, 20);
			label1.TabIndex = 7;
			label1.Text = "Поставьте оценки";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(21, 9);
			label2.Name = "label2";
			label2.Size = new Size(136, 20);
			label2.TabIndex = 8;
			label2.Text = "Введите фамилию";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(21, 64);
			label3.Name = "label3";
			label3.Size = new Size(186, 20);
			label3.TabIndex = 9;
			label3.Text = "Выберите дату рождения";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 150);
			label4.Name = "label4";
			label4.Size = new Size(93, 20);
			label4.TabIndex = 10;
			label4.Text = "Математика";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(120, 150);
			label5.Name = "label5";
			label5.Size = new Size(106, 20);
			label5.TabIndex = 11;
			label5.Text = "Информатика";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(232, 150);
			label6.Name = "label6";
			label6.Size = new Size(69, 20);
			label6.TabIndex = 12;
			label6.Text = "Ин. язык";
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(383, 334);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(birthdayPicker);
			Controls.Add(englishMarkInput);
			Controls.Add(csMarkInput);
			Controls.Add(mathMarkInput);
			Controls.Add(lastNameInput);
			Controls.Add(Cancel);
			Controls.Add(AddStudent);
			Name = "Form2";
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button AddStudent;
		private Button Cancel;
		private TextBox lastNameInput;
		private TextBox mathMarkInput;
		private TextBox csMarkInput;
		private TextBox englishMarkInput;
		private DateTimePicker birthdayPicker;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
	}
}