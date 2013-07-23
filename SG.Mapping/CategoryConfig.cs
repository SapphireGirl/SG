using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
   public  class CategoryConfig : EntityTypeConfiguration<Category>
    {
       public CategoryConfig()
       {
           HasKey(p => p.CategoryId);
           Property(p => p.Name).
               IsRequired().
               HasMaxLength(25).
               HasColumnName("Name").
               HasColumnType("string");

           Ignore(s => s.State);

           Map<Category>(m => m.ToTable("Categories"));
       }
    }
}
