using ClassLibrary.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Queries.Persistence.EntityConfigurations
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            


        }
    }
}