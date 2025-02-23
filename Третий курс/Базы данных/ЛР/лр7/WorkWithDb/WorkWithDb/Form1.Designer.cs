namespace WorkWithDb
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
			database = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			last_name = new DataGridViewTextBoxColumn();
			Birthday = new DataGridViewTextBoxColumn();
			mark_math = new DataGridViewTextBoxColumn();
			mark_informatics = new DataGridViewTextBoxColumn();
			mark_foreign = new DataGridViewTextBoxColumn();
			AddStudent = new Button();
			UpdateData = new Button();
			DeleteData = new Button();
			queryDatabase = new DataGridView();
			IdQuery = new DataGridViewTextBoxColumn();
			LastNameQuery = new DataGridViewTextBoxColumn();
			BirthdayQuery = new DataGridViewTextBoxColumn();
			Query = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
			OrderData = new Button();
			LastNameAndBirthdayQuery = new Button();
			FiveQuery = new Button();
			GetExcelentStudents = new Button();
			MoreTwenty = new Button();
			((System.ComponentModel.ISupportInitialize)database).BeginInit();
			((System.ComponentModel.ISupportInitialize)queryDatabase).BeginInit();
			SuspendLayout();
			// 
			// database
			// 
			database.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			database.Columns.AddRange(new DataGridViewColumn[] { Id, last_name, Birthday, mark_math, mark_informatics, mark_foreign });
			database.Location = new Point(12, 26);
			database.Name = "database";
			database.RowHeadersWidth = 51;
			database.Size = new Size(785, 365);
			database.TabIndex = 0;
			// 
			// Id
			// 
			Id.HeaderText = "Id";
			Id.MinimumWidth = 6;
			Id.Name = "Id";
			Id.Width = 125;
			// 
			// last_name
			// 
			last_name.HeaderText = "LatsName";
			last_name.MinimumWidth = 6;
			last_name.Name = "last_name";
			last_name.Width = 125;
			// 
			// Birthday
			// 
			Birthday.HeaderText = "Birthday";
			Birthday.MinimumWidth = 6;
			Birthday.Name = "Birthday";
			Birthday.Width = 125;
			// 
			// mark_math
			// 
			mark_math.HeaderText = "MarkMath";
			mark_math.MinimumWidth = 6;
			mark_math.Name = "mark_math";
			mark_math.Width = 125;
			// 
			// mark_informatics
			// 
			mark_informatics.HeaderText = "MarkCS";
			mark_informatics.MinimumWidth = 6;
			mark_informatics.Name = "mark_informatics";
			mark_informatics.Width = 125;
			// 
			// mark_foreign
			// 
			mark_foreign.HeaderText = "MarkEnglish";
			mark_foreign.MinimumWidth = 6;
			mark_foreign.Name = "mark_foreign";
			mark_foreign.Width = 125;
			// 
			// AddStudent
			// 
			AddStudent.Location = new Point(36, 420);
			AddStudent.Name = "AddStudent";
			AddStudent.Size = new Size(142, 53);
			AddStudent.TabIndex = 1;
			AddStudent.Text = "Добавить";
			AddStudent.UseVisualStyleBackColor = true;
			AddStudent.Click += AddStudent_Click;
			// 
			// UpdateData
			// 
			UpdateData.Location = new Point(272, 420);
			UpdateData.Name = "UpdateData";
			UpdateData.Size = new Size(142, 53);
			UpdateData.TabIndex = 2;
			UpdateData.Text = "Изменить";
			UpdateData.UseVisualStyleBackColor = true;
			UpdateData.Click += UpdateData_Click;
			// 
			// DeleteData
			// 
			DeleteData.Location = new Point(533, 420);
			DeleteData.Name = "DeleteData";
			DeleteData.Size = new Size(142, 53);
			DeleteData.TabIndex = 3;
			DeleteData.Text = "Удалить";
			DeleteData.UseVisualStyleBackColor = true;
			DeleteData.Click += DeleteData_Click;
			// 
			// queryDatabase
			// 
			queryDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			queryDatabase.Columns.AddRange(new DataGridViewColumn[] { IdQuery, LastNameQuery, BirthdayQuery, Query, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
			queryDatabase.Location = new Point(828, 26);
			queryDatabase.Name = "queryDatabase";
			queryDatabase.RowHeadersWidth = 51;
			queryDatabase.Size = new Size(785, 365);
			queryDatabase.TabIndex = 4;
			// 
			// IdQuery
			// 
			IdQuery.HeaderText = "Id";
			IdQuery.MinimumWidth = 6;
			IdQuery.Name = "IdQuery";
			IdQuery.Width = 125;
			// 
			// LastNameQuery
			// 
			LastNameQuery.HeaderText = "LatsName";
			LastNameQuery.MinimumWidth = 6;
			LastNameQuery.Name = "LastNameQuery";
			LastNameQuery.Width = 125;
			// 
			// BirthdayQuery
			// 
			BirthdayQuery.HeaderText = "Birthday";
			BirthdayQuery.MinimumWidth = 6;
			BirthdayQuery.Name = "BirthdayQuery";
			BirthdayQuery.Width = 125;
			// 
			// Query
			// 
			Query.HeaderText = "MarkMath";
			Query.MinimumWidth = 6;
			Query.Name = "Query";
			Query.Width = 125;
			// 
			// dataGridViewTextBoxColumn5
			// 
			dataGridViewTextBoxColumn5.HeaderText = "MarkCS";
			dataGridViewTextBoxColumn5.MinimumWidth = 6;
			dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			dataGridViewTextBoxColumn5.Width = 125;
			// 
			// dataGridViewTextBoxColumn6
			// 
			dataGridViewTextBoxColumn6.HeaderText = "MarkEnglish";
			dataGridViewTextBoxColumn6.MinimumWidth = 6;
			dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			dataGridViewTextBoxColumn6.Width = 125;
			// 
			// OrderData
			// 
			OrderData.Location = new Point(828, 410);
			OrderData.Name = "OrderData";
			OrderData.Size = new Size(142, 53);
			OrderData.TabIndex = 5;
			OrderData.Text = "Сортировка";
			OrderData.UseVisualStyleBackColor = true;
			OrderData.Click += OrderData_Click;
			// 
			// LastNameAndBirthdayQuery
			// 
			LastNameAndBirthdayQuery.Location = new Point(976, 410);
			LastNameAndBirthdayQuery.Name = "LastNameAndBirthdayQuery";
			LastNameAndBirthdayQuery.Size = new Size(142, 53);
			LastNameAndBirthdayQuery.TabIndex = 6;
			LastNameAndBirthdayQuery.Text = "Фамилия и др";
			LastNameAndBirthdayQuery.UseVisualStyleBackColor = true;
			LastNameAndBirthdayQuery.Click += LastNameAndBirthdayQuery_Click;
			// 
			// FiveQuery
			// 
			FiveQuery.Location = new Point(1124, 410);
			FiveQuery.Name = "FiveQuery";
			FiveQuery.Size = new Size(142, 53);
			FiveQuery.TabIndex = 7;
			FiveQuery.Text = "Отличники по мат.";
			FiveQuery.UseVisualStyleBackColor = true;
			FiveQuery.Click += FiveQuery_Click;
			// 
			// GetExcelentStudents
			// 
			GetExcelentStudents.Location = new Point(1272, 410);
			GetExcelentStudents.Name = "GetExcelentStudents";
			GetExcelentStudents.Size = new Size(142, 53);
			GetExcelentStudents.TabIndex = 8;
			GetExcelentStudents.Text = "Отличники";
			GetExcelentStudents.UseVisualStyleBackColor = true;
			GetExcelentStudents.Click += GetExcelentStudents_Click;
			// 
			// MoreTwenty
			// 
			MoreTwenty.Location = new Point(1420, 410);
			MoreTwenty.Name = "MoreTwenty";
			MoreTwenty.Size = new Size(142, 53);
			MoreTwenty.TabIndex = 9;
			MoreTwenty.Text = "Старше 20";
			MoreTwenty.UseVisualStyleBackColor = true;
			MoreTwenty.Click += MoreTwenty_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1652, 577);
			Controls.Add(MoreTwenty);
			Controls.Add(GetExcelentStudents);
			Controls.Add(FiveQuery);
			Controls.Add(LastNameAndBirthdayQuery);
			Controls.Add(OrderData);
			Controls.Add(queryDatabase);
			Controls.Add(DeleteData);
			Controls.Add(UpdateData);
			Controls.Add(AddStudent);
			Controls.Add(database);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)database).EndInit();
			((System.ComponentModel.ISupportInitialize)queryDatabase).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView database;
		private Button AddStudent;
		private Button UpdateData;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn last_name;
		private DataGridViewTextBoxColumn Birthday;
		private DataGridViewTextBoxColumn mark_math;
		private DataGridViewTextBoxColumn mark_informatics;
		private DataGridViewTextBoxColumn mark_foreign;
		private Button DeleteData;
		private DataGridView queryDatabase;
		private DataGridViewTextBoxColumn IdQuery;
		private DataGridViewTextBoxColumn LastNameQuery;
		private DataGridViewTextBoxColumn BirthdayQuery;
		private DataGridViewTextBoxColumn Query;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private Button OrderData;
		private Button LastNameAndBirthdayQuery;
		private Button FiveQuery;
		private Button GetExcelentStudents;
		private Button MoreTwenty;
	}
}
