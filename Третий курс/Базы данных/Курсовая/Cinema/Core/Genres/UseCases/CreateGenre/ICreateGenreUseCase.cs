namespace Core.Genres.UseCases.CreateGenre;

public interface ICreateGenreUseCase
{
    void Handle(string genreName);
}