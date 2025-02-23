using WorkWithDb.Database;
using WorkWithDb.Domain;

namespace WorkWithDb;

public partial class AddDataForm : Form
{
	private readonly DbContext _dbContext;
	private readonly int _id;

	public AddDataForm(DbContext dbContext, int studentId)
	{
		InitializeComponent();
		_dbContext = dbContext;
		_id = studentId;
	}

	private void Cancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AddStudent_Click(object sender, EventArgs e)
	{
		var student = new Student
		{
			Id = _id,
			LastName = lastNameInput.Text,
			Birthday = birthdayPicker.Value,
			MarkMath = int.Parse(mathMarkInput.Text),
			MarkCS = int.Parse(csMarkInput.Text),
			MarkEnglish = int.Parse(englishMarkInput.Text)
		};
		_dbContext.AddData(student);
		Close();
	}
}
