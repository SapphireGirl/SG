using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class ShareLineItemConfig : EntityTypeConfiguration<ShareLineItem>
    {

        public ShareLineItemConfig()
        {
            HasKey(k => k.ShareLineItemId);

            HasRequired(s => s.LineProduce);

            //not mapped to database
            Ignore(t => t.LineTotal);

            // Foreign Key

            HasRequired(p => p.Share)
                .WithMany(sl => sl.ShareLineItems);

            Map<ShareLineItem>(m => m.ToTable("ShareLineItems"));
        }
            
    }
}
