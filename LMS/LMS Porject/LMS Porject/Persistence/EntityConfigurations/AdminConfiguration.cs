using ClassLibrary.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Queries.Persistence.EntityConfigurations
{
    public class AdminConfiguration : EntityTypeConfiguration<Admin>
    {
        public AdminConfiguration()
        {
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            

            
        }
    }
}