using HomeManager.Models;
using HomeManager.Repositories;

namespace HomeManager.Services;
public class MovieService : IMovieService
{
    private readonly IMovieRepository _repo;

    public MovieService(IMovieRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Movie>> GetAllMoviesAsync()
    {
        return await _repo.GetAllAsync();
    }
}
