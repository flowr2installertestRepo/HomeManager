using HomeManager.Models;
using HomeManager.Repositories;

namespace HomeManager.Services;
public class MenuService : IMenuService
{
    private readonly IMenuRepository _repo;

    public MenuService(IMenuRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Menu>> GetAllMenusAsync()
    {
        return await _repo.GetAllAsync();
    }
}
