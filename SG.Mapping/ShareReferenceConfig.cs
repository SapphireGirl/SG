using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class ShareReferenceConfig : EntityTypeConfiguration<ShareReference>
    {
        public ShareReferenceConfig()
        {
            HasKey(k => k.ShareId);
            Property(p => p.FullSharePrice).HasPrecision(5, 2);
            Property(p => p.HalfSharePrice).HasPrecision(5, 2);
            Map<ShareReference>(m => m.ToTable("ShareReferences"));
        }

    }
}
