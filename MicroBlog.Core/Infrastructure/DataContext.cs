using MicroBlog.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroBlog.Core.Infrastructure;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts  { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}