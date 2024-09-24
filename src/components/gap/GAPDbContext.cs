using Microsoft.EntityFrameworkCore;
using Nexuria.GAP.Models;

namespace Nexuria.GAP
{
    public class GAPDbContext : DbContext
    {
        public GAPDbContext(DbContextOptions<GAPDbContext> options) : base(options)
        {
        }

        public DbSet<Adoption> Adoptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adoption>().HasKey(a => a.Id);
        }
    }
}
