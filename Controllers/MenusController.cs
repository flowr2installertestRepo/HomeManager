using HomeManager.Models;
using HomeManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeManager.Controllers;

[ApiController]
[Route("[controller]")]
public class MenusController : ControllerBase
{
    private readonly IMenuService _service;

    public MenusController(IMenuService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Menu>>> Get()
    {
        var movies = await _service.GetAllMenusAsync();
        return Ok(movies);
    }
}
