using System.Data.Entity.ModelConfiguration;
using SG.Model;


namespace SG.Mapping
{
    public class AddressConfig : ComplexTypeConfiguration<Address>
    {
        public AddressConfig()
        {

            // Street Address
            Property(p => p.StreetAddress).
               IsRequired().
               HasMaxLength(150).
               HasColumnName("StreetAddress").
               HasColumnType("string");
            // City
            Property(p => p.City).
                IsRequired().
                HasMaxLength(50).
                HasColumnName("City");
            // Region
            Property(p => p.Region).
                IsRequired().
                HasMaxLength(25).
                HasColumnName("Region");
            // ZipCode
            Property(p => p.ZipCode).
                IsRequired().
                HasMaxLength(10).
                HasColumnName("ZipCode");

            // Not Mapping to a table
            //Map<Coop>(m => m.ToTable("Coops"));
        }
    }
}
