using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entity.Student;

namespace RepositoryPattern.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Family>()
                .HasIndex(x => x.Code)
                .IsUnique();
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<GuardianType> GuardianTypes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
