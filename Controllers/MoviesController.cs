using HomeManager.Models;
using HomeManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace HomeManager.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _service;

    public MoviesController(IMovieService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<Movie>>> Get()
    {
        var movies = await _service.GetAllMoviesAsync();
        return Ok(movies);
    }
}
