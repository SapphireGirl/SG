using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class ShareConfig : EntityTypeConfiguration<Share>
    {
        public ShareConfig()
        {
            HasKey(k => k.ShareId);
            Property(p => p.FullSharePrice).HasPrecision(5, 2);
            Property(p => p.HalfSharePrice).HasPrecision(5, 2);
          //  Property(d => d.Day);

            HasOptional(sl => sl.ShareLineItems);
            Map<Share>(m => m.ToTable("Shares"));
        }
    }

    public class ShareTypeConfig : ComplexTypeConfiguration<ShareType>
    {
        public ShareTypeConfig()
        {
            Property(v => v.Value);
        }
    }
}
