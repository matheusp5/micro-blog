using MicroBlog.Core.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MicroBlog.Categories.Controllers;

[ApiController]
[Route("api/categories")]
public class CategoriesController : ControllerBase
{
    private readonly DataContext _dataContext;

    public CategoriesController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await this._dataContext
            .Categories
            .ToListAsync());
    }
    
    
    [HttpGet("category/{id}")]
    public async Task<IActionResult> Get([FromRoute] int id)
    {
        return Ok(await this._dataContext
            .Categories
            .FirstOrDefaultAsync(c => c.Id == id));
    }
}