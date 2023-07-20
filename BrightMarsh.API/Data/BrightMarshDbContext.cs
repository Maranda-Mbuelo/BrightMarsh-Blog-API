using Microsoft.EntityFrameworkCore;
using BrightMarsh.API.Models.Entities;

public class BrightMarshDbContext:DbContext
{

    public BrightMarshDbContext(DbContextOptions options) : base(options)
    {

    }

    //DbSet

    public DbSet<Post> Posts { get; set; }
}
