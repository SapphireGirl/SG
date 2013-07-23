using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class ProduceConfig : EntityTypeConfiguration<Produce>
    {
        public ProduceConfig()
        {
            HasKey(p => p.ProduceId);
            Property(b => b.Name).
                HasMaxLength(25);
                


            // currently 4.3 EF does not support Enums;  Port to 5.0
       //     HasRequired(p => p.PA);
            Map<Produce>(m => m.ToTable("Produce"));

        }
    }
}
