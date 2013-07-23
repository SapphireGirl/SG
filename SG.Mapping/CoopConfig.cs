using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class CoopConfig : EntityTypeConfiguration<Coop>
    {
        public CoopConfig()
        {
            
            HasKey(p => p.CoopId);
            Property(p => p.Name).
                IsRequired().
                HasMaxLength(50);
                

            //HasOptional(a => new {a.CoopAddress});
            //HasOptional(a =>  a.CoopAddress );

            // Configuring the Address Property
            // Street Address
            //Property(p => p.CoopAddress.StreetAddress).
            //   IsRequired().
            //   HasMaxLength(150).
            //   HasColumnName("StreetAddress").
            //   HasColumnType("string");
            // City
            //Property(p => p.CoopAddress.City).
            //    IsRequired().
            //    HasMaxLength(50).
            //    HasColumnName("City");
            // Region
            //Property(p => p.CoopAddress.Region).
            //    IsRequired().
            //    HasMaxLength(25).
            //    HasColumnName("Region");
            // ZipCode
            //Property(p => p.CoopAddress.ZipCode).
            //    IsRequired().
            //    HasMaxLength(10).
            //    HasColumnName("ZipCode");

            //Ignore(s  => s.State);

            Map<Coop>(m => m.ToTable("Coops"));
          
        }
    }
}
