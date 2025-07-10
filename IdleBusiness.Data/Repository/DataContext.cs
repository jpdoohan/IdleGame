using Microsoft.EntityFrameworkCore;
using IdleBusiness.Data.Entities;

namespace IdleBusiness.Data.Repository;

public class DataContext : DbContext
{
    public DbSet<Cash> Cash { get; set; }
    public DbSet<Investment> Investment { get; set; }
    public DbSet<User> Users { get; set; }

  
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }


    public void Initialise() 
    {
        Database.EnsureCreated();
    }
}
