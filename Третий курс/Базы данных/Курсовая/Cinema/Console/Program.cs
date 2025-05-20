using System.Text.Json;
using Core.Genres.UseCases.CreateGenre;
using Infrastructure.Genres;
using Infrastructure.Options;

var settings = JsonDocument.Parse(File.ReadAllText("appsettings.json"));
// var connectionStrings = JsonSerializer.Deserialize<ConnectionStrings>(settings.RootElement.GetProperty("ConnectionStrings"));
// var repos = new GenreRepository(connectionStrings);
// var useCase = new CreateGenreUseCase(repos);
// useCase.Handle("Драма");
// foreach (var genre in repos.Get())
// {
// 	Console.WriteLine(genre.DisplayName);
// }