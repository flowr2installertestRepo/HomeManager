using HomeManager.Data;
using HomeManager.Models;
using MongoDB.Driver;

namespace HomeManager.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly MongoContext _context;

    public MovieRepository(MongoContext context)
    {
        _context = context;
    }

    public async Task<List<Movie>> GetAllAsync()
    {
        return await _context.Movies.Find(_ => true).ToListAsync();
    }

    // Insert menu
    //collection.InsertOne(menu);
}
