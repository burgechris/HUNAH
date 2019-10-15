using Microsoft.EntityFrameworkCore;

namespace Hunah.Models
{
    public class HunahContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public HunahContext(DbContextOptions options) : base(options) { }
    }
}