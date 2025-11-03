namespace HomeManager.Repositories;
using HomeManager.Models;

public interface IMenuRepository
{
    Task<List<Menu>> GetAllAsync();
    // Add: GetByIdAsync, CreateAsync, UpdateAsync, DeleteAsync (if needed)
}
