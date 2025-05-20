namespace Core.Genres.Repositories;

public interface IGenreRepository
{
    Result Add(Genre genre);

    IEnumerable<Genre> GetGenres();

    Result Update(string oldName, Genre genre);

    Result Delete(string genreName);
}