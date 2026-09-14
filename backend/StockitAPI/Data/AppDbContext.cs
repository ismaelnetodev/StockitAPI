using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace StockitAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // O que é isso?
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
    public DbSet<Family.Family> Families { get; set; }
    public DbSet<User.User> Users { get; set; }
}