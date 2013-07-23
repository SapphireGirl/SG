using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class IngredientConfig : EntityTypeConfiguration<Ingredient>
    {

        public IngredientConfig()
        {
            HasKey(k => k.IngredientId);

            Property(p => p.Name).
                IsRequired().
                HasMaxLength(50).
                HasColumnName("Name").
                HasColumnType("string");

            Property(c => c.Cost).HasPrecision(8, 2).IsRequired();

            Property(c => c.Unit).HasMaxLength(25).IsRequired();

            Property(d => d.DateCreated).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(d => d.DateUpdated).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

           

            // Navigation Mapping 1 Recipe to Many Ingredients
            HasMany(f => f.RecipesWith);

            








            //HasOptional(c => c.PrimaryCategoryCode).WithOptionalDependent();

            Map<Ingredient>(m => m.ToTable("Ingredients"));
        }

    }
}
