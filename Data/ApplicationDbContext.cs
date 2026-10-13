using Microsoft.EntityFrameworkCore;
using domashnoBaza.Models;

namespace domashnoBaza.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}