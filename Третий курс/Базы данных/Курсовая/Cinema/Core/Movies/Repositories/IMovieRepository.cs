namespace Core.Movies.Repositories;

public interface IMovieRepository
{
	Result Add(Movie movie);

	Result Update(Movie oldData, Movie movie);
	
	IEnumerable<Movie> GetMovies();

	Result Delete(Movie movie);
}
