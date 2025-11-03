namespace HomeManager.Repositories;
using HomeManager.Models;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    // Add: GetByIdAsync, CreateAsync, UpdateAsync, DeleteAsync (if needed)
}
