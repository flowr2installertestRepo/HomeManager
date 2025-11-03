using HomeManager.Models;

namespace HomeManager.Services;

public interface IMovieService
{
    Task<List<Movie>> GetAllMoviesAsync();
}
