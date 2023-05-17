using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CF.Entities.Configs
{
    public class StudentEfConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.Id).HasName("Student_pk");
            builder.Property(e => e.Id).UseIdentityColumn();
            //builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.IndexNumber).IsRequired().HasMaxLength(15);

            builder.ToTable("Student");
        }
    }
}
