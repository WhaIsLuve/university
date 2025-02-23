namespace WorkWithDb.Domain;

public class Student
{
	public const string IdColumn = "id";

	public const string LastNameColumn = "last_name";

	public const string BirthdayColumn = "birthday";

	public const string MarkMathColumn = "mark_math";

	public const string MarkCsColumn = "mark_informatics";

	public const string MarkEnglishColumn = "mark_foreign";
	
	public int Id { get; set; }

	public string LastName { get; set; } = null!;

	public DateTime Birthday { get; set; }

	public int MarkMath { get; set; }

	public int MarkCS { get; set; }

	public int MarkEnglish { get; set; }
}
