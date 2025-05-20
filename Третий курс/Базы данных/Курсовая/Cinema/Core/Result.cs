namespace Core;

public class Result
{
	private Result(bool isSuccess)
	{
		IsSuccess = isSuccess;
	}

	public bool IsSuccess
	{
		get;
		init;
	}

	public static Result Success() => new Result(true);

	public static Result Failure() => new Result(false);
}
