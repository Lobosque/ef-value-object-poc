using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ValueObjectPoc.OwnedEntities
{
    public class OwnedEntityContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseSqlite("Data Source=blogging.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().OwnsOne(
                o => o.Ssn,
                sa =>
                {
                    sa.Property(p => p.Value).HasColumnName("Ssn");
                });

        }
    }
}