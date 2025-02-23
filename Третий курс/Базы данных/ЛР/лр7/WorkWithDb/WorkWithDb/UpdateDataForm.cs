using WorkWithDb.Database;
using WorkWithDb.Domain;

namespace WorkWithDb;

public partial class UpdateDataForm : Form
{
	private readonly DbContext _dbContext;
	private Student _student;

	public UpdateDataForm(DbContext dbContext, Student student)
	{
		InitializeComponent();
		_dbContext = dbContext;
		_student = student;
		lastNameInput.Text = student.LastName;
		birthdayPicker.Value = student.Birthday;
		mathMarkInput.Text = student.MarkMath.ToString();
		csMarkInput.Text = student.MarkCS.ToString();
		englishMarkInput.Text = student.MarkEnglish.ToString();
	}

	private void Cancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void UpdateStudent_Click(object sender, EventArgs e)
	{
		_student.LastName = lastNameInput.Text;
		_student.MarkCS = int.Parse(csMarkInput.Text);
		_student.Birthday = birthdayPicker.Value;
		_student.MarkMath = int.Parse(mathMarkInput.Text);
		_student.MarkEnglish = int.Parse(englishMarkInput.Text);
		_dbContext.UpdateData(_student);
		Close();
	}
}
