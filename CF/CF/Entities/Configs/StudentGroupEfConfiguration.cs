using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CF.Entities.Configs
{
    public class StudentGroupEfConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(e => new { e.IdGroup, e.IdStudent }).HasName("StudentGroup_pk");

            builder.Property(e => e.AddedAt).IsRequired().HasDefaultValueSql("GETDATE()");

            builder.HasOne(e => e.Student)
                  .WithMany(e => e.StudentGroups)
                  .HasForeignKey(e => e.IdStudent)
                  .HasConstraintName("StudentGroup_Student")
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Group)
                  .WithMany(e => e.StudentGroups)
                  .HasForeignKey(e => e.IdGroup)
                  .HasConstraintName("StudentGroup_Group")
                  .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Student_Group");
        }
    }
}
