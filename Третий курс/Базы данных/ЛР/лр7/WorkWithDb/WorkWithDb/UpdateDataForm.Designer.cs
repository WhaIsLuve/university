﻿namespace WorkWithDb
{
	partial class UpdateDataForm
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
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			birthdayPicker = new DateTimePicker();
			englishMarkInput = new TextBox();
			csMarkInput = new TextBox();
			mathMarkInput = new TextBox();
			lastNameInput = new TextBox();
			Cancel = new Button();
			UpdateStudent = new Button();
			SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(223, 150);
			label6.Name = "label6";
			label6.Size = new Size(69, 20);
			label6.TabIndex = 25;
			label6.Text = "Ин. язык";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(111, 150);
			label5.Name = "label5";
			label5.Size = new Size(106, 20);
			label5.TabIndex = 24;
			label5.Text = "Информатика";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 150);
			label4.Name = "label4";
			label4.Size = new Size(93, 20);
			label4.TabIndex = 23;
			label4.Text = "Математика";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 64);
			label3.Name = "label3";
			label3.Size = new Size(186, 20);
			label3.TabIndex = 22;
			label3.Text = "Выберите дату рождения";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 9);
			label2.Name = "label2";
			label2.Size = new Size(136, 20);
			label2.TabIndex = 21;
			label2.Text = "Введите фамилию";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 126);
			label1.Name = "label1";
			label1.Size = new Size(135, 20);
			label1.TabIndex = 20;
			label1.Text = "Поставьте оценки";
			// 
			// birthdayPicker
			// 
			birthdayPicker.Location = new Point(12, 87);
			birthdayPicker.Name = "birthdayPicker";
			birthdayPicker.Size = new Size(250, 27);
			birthdayPicker.TabIndex = 19;
			// 
			// englishMarkInput
			// 
			englishMarkInput.Location = new Point(226, 173);
			englishMarkInput.Name = "englishMarkInput";
			englishMarkInput.Size = new Size(36, 27);
			englishMarkInput.TabIndex = 18;
			// 
			// csMarkInput
			// 
			csMarkInput.Location = new Point(112, 173);
			csMarkInput.Name = "csMarkInput";
			csMarkInput.Size = new Size(36, 27);
			csMarkInput.TabIndex = 17;
			// 
			// mathMarkInput
			// 
			mathMarkInput.Location = new Point(12, 173);
			mathMarkInput.Name = "mathMarkInput";
			mathMarkInput.Size = new Size(36, 27);
			mathMarkInput.TabIndex = 16;
			// 
			// lastNameInput
			// 
			lastNameInput.Location = new Point(12, 34);
			lastNameInput.Name = "lastNameInput";
			lastNameInput.Size = new Size(290, 27);
			lastNameInput.TabIndex = 15;
			// 
			// Cancel
			// 
			Cancel.Location = new Point(168, 296);
			Cancel.Name = "Cancel";
			Cancel.Size = new Size(94, 29);
			Cancel.TabIndex = 14;
			Cancel.Text = "Отмена";
			Cancel.UseVisualStyleBackColor = true;
			Cancel.Click += Cancel_Click;
			// 
			// UpdateStudent
			// 
			UpdateStudent.Location = new Point(268, 296);
			UpdateStudent.Name = "UpdateStudent";
			UpdateStudent.Size = new Size(94, 29);
			UpdateStudent.TabIndex = 13;
			UpdateStudent.Text = "Обновить";
			UpdateStudent.UseVisualStyleBackColor = true;
			UpdateStudent.Click += UpdateStudent_Click;
			// 
			// UpdateDataForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(370, 350);
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
			Controls.Add(UpdateStudent);
			Name = "UpdateDataForm";
			Text = "UpdateDataForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private DateTimePicker birthdayPicker;
		private TextBox englishMarkInput;
		private TextBox csMarkInput;
		private TextBox mathMarkInput;
		private TextBox lastNameInput;
		private Button Cancel;
		private Button UpdateStudent;
	}
}