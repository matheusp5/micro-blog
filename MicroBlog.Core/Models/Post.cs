namespace MicroBlog.Core.Models;

public class Post : BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Content { get; set; }
    public string? Slug { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
}
