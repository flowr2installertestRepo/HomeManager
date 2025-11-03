namespace HomeManager.Repositories;
using HomeManager.Models;

public interface IMovieRepository
{
    Task<List<Movie>> GetAllAsync();
    // Add: GetByIdAsync, CreateAsync, UpdateAsync, DeleteAsync (if needed)
}
