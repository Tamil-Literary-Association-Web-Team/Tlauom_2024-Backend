using Microsoft.EntityFrameworkCore;
using Tlauom_2024.Entities.Models;

namespace Tlauom_2024.Entities
{
    public class TLAContext : DbContext
    {
            public TLAContext(DbContextOptions<TLAContext> options)
                : base(options)
        {

            }
        public DbSet<District> Districts { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply configurations
        }
    }
}
