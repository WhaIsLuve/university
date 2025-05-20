namespace Core.Movies;

public class Movie
{
	public Movie(string displayName, int rating, TimeSpan duration, string? country, string genres)
	{
		DisplayName = displayName;
		Rating = rating;
		Duration = duration;
		Country = country;
		Genres = genres;
	}

	public Movie()
	{
		
	}

	public string DisplayName
	{
		get;
		init;
	}

	public int Rating
	{
		get;
		init;
	}

	public TimeSpan Duration
	{
		get;
		init;
	}

	public string? Country
	{
		get;
		init;
	}

	public string Genres
	{
		get;
		init;
	}
}
