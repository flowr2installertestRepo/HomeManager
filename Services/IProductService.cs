using HomeManager.Models;

namespace HomeManager.Services;

public interface IProductService
{
    Task<List<Product>> GetAllProductsAsync();
}
