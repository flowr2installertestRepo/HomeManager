using HomeManager.Models;
using HomeManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeManager.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;

    public ProductsController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> Get()
    {
        var products = await _service.GetAllProductsAsync();
        return Ok(products);
    }
}
