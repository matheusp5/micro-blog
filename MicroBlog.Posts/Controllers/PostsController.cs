using MicroBlog.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MicroBlog.Posts.Controllers;

[ApiController]
[Route("api/posts")]
public class PostsController : ControllerBase
{
    private readonly DataContext _dataContext;

    public PostsController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _dataContext.Posts.Include(c => c.Category).ToListAsync());
    }
    
    [HttpGet("post/{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        return Ok(await _dataContext.Posts.Include(c => c.Category).FirstOrDefaultAsync(p => p.Id == id));
    }
    
}