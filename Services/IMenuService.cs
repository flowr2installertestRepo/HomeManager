using HomeManager.Models;

namespace HomeManager.Services;

public interface IMenuService
{
    Task<List<Menu>> GetAllMenusAsync();
}
