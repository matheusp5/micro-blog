namespace MicroBlog.Core.Models;

public class Category : BaseModel
{
    public string? Name { get; set; }
    public string? Slug { get; set; }
}