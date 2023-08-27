using MicroBlog.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MicroBlog.Posts.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostsController : ControllerBase
{
    private readonly DataContext _dataContext;

    public PostsController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet(Name = "/")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _dataContext.Posts.Include(c => c.Category).ToListAsync());
    }
    
}