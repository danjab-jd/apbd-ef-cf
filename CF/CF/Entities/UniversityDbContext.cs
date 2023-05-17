using CF.Entities.Configs;
using Microsoft.EntityFrameworkCore;

namespace CF.Entities
{
    public class UniversityDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Group> Groups { get; set; }

        public UniversityDbContext()
        {
        }

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupEfConfiguration).Assembly);
        }
    }
}
