using ClassLibrary.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Queries.Persistence.EntityConfigurations
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

           
        }
    }
}