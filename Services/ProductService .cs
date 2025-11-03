using HomeManager.Models;
using HomeManager.Repositories;

namespace HomeManager.Services;
public class ProductService : IProductService
{
    private readonly IProductRepository _repo;

    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Product>> GetAllProductsAsync()
    {
        return await _repo.GetAllAsync();
    }
}
