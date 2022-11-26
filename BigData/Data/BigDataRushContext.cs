using BigData.Models;
using Microsoft.EntityFrameworkCore;

namespace BigData.Data;

public class BigDataRushContext : DbContext
{
    public BigDataRushContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Database=bigdata;Port=5432;User Id=postgres;Password=1844600");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }
    
    public DbSet<Product> products { get; set; }
}