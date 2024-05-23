using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Entity.Student;

namespace RepositoryPattern.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<GuardianType> GuardianTypes { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
