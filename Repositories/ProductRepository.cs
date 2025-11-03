using HomeManager.Data;
using HomeManager.Models;
using MongoDB.Driver;

namespace HomeManager.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly MongoContext _context;

    public ProductRepository(MongoContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _context.Products.Find(_ => true).ToListAsync();
    }
}
