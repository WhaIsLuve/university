using System.Data.OleDb;
using WorkWithDb.Domain;

namespace WorkWithDb.Database;

public class DbContext
{
	private const string _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Влад\Desktop\Университет\Третий курс\Базы данных\ЛР\lr3.mdb;";

	public void SelectAllData(DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		using var connection = new OleDbConnection(_connectionString);
		var query = """
			select id, last_name, birthday, mark_math, mark_informatics, mark_foreign
				from students;
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		using OleDbDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			dataGridView.Rows.Add(reader[Student.IdColumn],
				reader[Student.LastNameColumn], 
				reader[Student.BirthdayColumn], 
				reader[Student.MarkMathColumn], 
				reader[Student.MarkCsColumn], 
				reader[Student.MarkEnglishColumn]);
		}
		connection.Close();
	}

	public void AddData(Student student)
	{
		using var connection = new OleDbConnection(_connectionString);

		var query = $"""
			insert into students(id, last_name, birthday, mark_math, mark_informatics, mark_foreign)
				values(@id, @lastName, @birthday, @math, @cs, @english);
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		command.Parameters.AddWithValue("@id", student.Id);
		command.Parameters.AddWithValue("@lastName", student.LastName);
		command.Parameters.AddWithValue("@birthday", student.Birthday.Date);
		command.Parameters.AddWithValue("@math", student.MarkMath);
		command.Parameters.AddWithValue("@cs", student.MarkCS);
		command.Parameters.AddWithValue("@english", student.MarkEnglish);
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void UpdateData(Student student)
	{
		using var connection = new OleDbConnection(_connectionString);
		var query = """
			update students
				set last_name=@lastName, birthday=@birthday, mark_math=@math, mark_informatics=@cs, mark_foreign=@english
					where id=@id;
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		command.Parameters.AddWithValue("@lastName", student.LastName);
		command.Parameters.AddWithValue("@birthday", student.Birthday.Date);
		command.Parameters.AddWithValue("@math", student.MarkMath);
		command.Parameters.AddWithValue("@cs", student.MarkCS);
		command.Parameters.AddWithValue("@english", student.MarkEnglish);
		command.Parameters.AddWithValue("@id", student.Id);
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void DeleteData(int id)
	{
		using var connection = new OleDbConnection(_connectionString);
		var query = """
			delete from students 
				where id=@id
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		command.Parameters.AddWithValue("@id", id);
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void OrderData(DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		using var connection = new OleDbConnection(_connectionString);
		var query = """
			select id, last_name, birthday, mark_math, mark_informatics, mark_foreign
				from students
				order by last_name;
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		using OleDbDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			dataGridView.Rows.Add(reader[Student.IdColumn],
				reader[Student.LastNameColumn],
				reader[Student.BirthdayColumn],
				reader[Student.MarkMathColumn],
				reader[Student.MarkCsColumn],
				reader[Student.MarkEnglishColumn]);
		}
		connection.Close();
	}

	public void LastNameAndBirhtdayQuery(DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		using var connection = new OleDbConnection(_connectionString);
		var query = """
			select id, last_name, birthday
				from students;
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		using OleDbDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			dataGridView.Rows.Add(string.Empty, 
				reader[Student.LastNameColumn],
				reader[Student.BirthdayColumn]);
		}
		connection.Close();
	}

	public void QueryWhereMarkMathEqualsFive(DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		using var connection = new OleDbConnection(_connectionString);
		var query = """
			select id, last_name, birthday, mark_math, mark_informatics, mark_foreign
				from students
				where mark_math = 5;
			""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		using OleDbDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			dataGridView.Rows.Add(reader[Student.IdColumn],
				reader[Student.LastNameColumn],
				reader[Student.BirthdayColumn],
				reader[Student.MarkMathColumn],
				reader[Student.MarkCsColumn],
				reader[Student.MarkEnglishColumn]);
		}
		connection.Close();
	}

	public void QueryExcelentStudents(DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		using var connection = new OleDbConnection(_connectionString);
		var query = """
		select id, last_name, birthday, mark_math, mark_informatics, mark_foreign
			from students
			where mark_math = 5 and mark_informatics = 5 and mark_foreign = 5;
		""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		using OleDbDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			dataGridView.Rows.Add(reader[Student.IdColumn],
				reader[Student.LastNameColumn],
				reader[Student.BirthdayColumn],
				reader[Student.MarkMathColumn],
				reader[Student.MarkCsColumn],
				reader[Student.MarkEnglishColumn]);
		}
		connection.Close();
	}

	public void QueryWhereAgeMoreTwenty(DataGridView dataGridView)
	{
		dataGridView.Rows.Clear();
		using var connection = new OleDbConnection(_connectionString);
		var query = """
		select id, last_name, birthday, mark_math, mark_informatics, mark_foreign
			from students
			where DateDiff('yyyy',  birthday, Date()) >= 20;
		""";
		connection.Open();
		using var command = new OleDbCommand(query, connection);
		using OleDbDataReader reader = command.ExecuteReader();
		while (reader.Read())
		{
			dataGridView.Rows.Add(reader[Student.IdColumn],
				reader[Student.LastNameColumn],
				reader[Student.BirthdayColumn],
				reader[Student.MarkMathColumn],
				reader[Student.MarkCsColumn],
				reader[Student.MarkEnglishColumn]);
		}
		connection.Close();
	}
}
