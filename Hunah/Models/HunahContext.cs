using Microsoft.EntityFrameworkCore;

namespace Hunah.Models
{
    public class HunahContext : DbContext
    {
       
    public virtual DbSet<Species> Species { get; set; } 
    public DbSet<Animal> Animals { get; set; }

    public HunahContext(DbContextOptions options) : base(options) { }

    }
}