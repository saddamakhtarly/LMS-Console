using ClassLibrary.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Queries.Persistence.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(255);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            Property(c => c.Marks)
                .IsRequired();           
           
        }
    }
}