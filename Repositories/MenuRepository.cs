using HomeManager.Data;
using HomeManager.Models;
using MongoDB.Driver;

namespace HomeManager.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly MongoContext _context;

    public MenuRepository(MongoContext context)
    {
        _context = context;
    }

    public async Task<List<Menu>> GetAllAsync()
    {
        return await _context.Menus.Find(_ => true).ToListAsync();
    }
}
