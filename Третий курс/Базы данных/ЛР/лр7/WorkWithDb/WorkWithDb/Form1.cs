using WorkWithDb.Database;
using WorkWithDb.Domain;

namespace WorkWithDb;

public partial class Form1 : Form
{
	private readonly DbContext _dbContext;

	public Form1()
	{
		InitializeComponent();
		_dbContext = new DbContext();
		_dbContext.SelectAllData(database);
	}

	private void AddStudent_Click(object sender, EventArgs e)
	{
		var form2 = new AddDataForm(_dbContext, database.Rows.Count);
		form2.ShowDialog();
		_dbContext.SelectAllData(database);
	}

	private void UpdateData_Click(object sender, EventArgs e)
	{
		if (database.SelectedRows.Count == 0)
		{
			MessageBox.Show("Ќужно выбрать строку которую хотите изменить");
			return;
		}
		var selectedRow = database.SelectedRows[0].Cells;
		var student = new Student
		{
			Id = int.Parse(selectedRow[0].Value.ToString()!),
			LastName = selectedRow[1].Value.ToString()!,
			Birthday = DateTime.Parse(selectedRow[2].Value.ToString()!),
			MarkMath = int.Parse(selectedRow[3].Value.ToString()!),
			MarkCS = int.Parse(selectedRow[4].Value.ToString()!),
			MarkEnglish = int.Parse(selectedRow[5].Value.ToString()!)
		};
		var updateForm = new UpdateDataForm(_dbContext, student);
		updateForm.ShowDialog();
		_dbContext.SelectAllData(database);
	}

	private void DeleteData_Click(object sender, EventArgs e)
	{
		if (database.SelectedRows.Count == 0)
		{
			MessageBox.Show("Ќужно выбрать строку которую хотите изменить");
			return;
		}
		var id = int.Parse(database.SelectedRows[0].Cells[0].Value.ToString()!);
		_dbContext.DeleteData(id);
		_dbContext.SelectAllData(database);
	}

	private void OrderData_Click(object sender, EventArgs e)
	{
		_dbContext.OrderData(queryDatabase);
	}

	private void LastNameAndBirthdayQuery_Click(object sender, EventArgs e)
	{
		_dbContext.LastNameAndBirhtdayQuery(queryDatabase);
	}

	private void FiveQuery_Click(object sender, EventArgs e)
	{
		_dbContext.QueryWhereMarkMathEqualsFive(queryDatabase);
	}

	private void GetExcelentStudents_Click(object sender, EventArgs e)
	{
		_dbContext.QueryExcelentStudents(queryDatabase);
	}

	private void MoreTwenty_Click(object sender, EventArgs e)
	{
		_dbContext.QueryWhereAgeMoreTwenty(queryDatabase);
	}
}
