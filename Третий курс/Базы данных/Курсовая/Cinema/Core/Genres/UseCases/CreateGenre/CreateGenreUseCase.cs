using Core.Genres.Repositories;

namespace Core.Genres.UseCases.CreateGenre;

public class CreateGenreUseCase : ICreateGenreUseCase
{
    private readonly IGenreRepository _genreRepository;
    
    public CreateGenreUseCase(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }
    
    public void Handle(string genreName)
    {
        var genre = new Genre(genreName);
        _genreRepository.Add(genre);
    }
}