using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class RecipeConfig : EntityTypeConfiguration<Recipe>
    {
        public RecipeConfig()
        {
            HasKey(k => k.RecipeId);

            Property(p => p.Name).
                IsRequired().
                IsFixedLength().
                HasMaxLength(50).
                HasColumnType("string");

            Property(p => p.Country).
                IsOptional().
                IsFixedLength().
                HasMaxLength(50).
                HasColumnType("string");

            Property(p => p.Description).
                IsOptional().
                IsFixedLength().
                HasMaxLength(250).
                HasColumnType("string");

            // Date Created
            Property(p => p.DateCreated).
                HasColumnName("DateAdded").
                HasColumnOrder(1).
                HasColumnType("date").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            // Date Updated
            Property(p => p.DateUpdated).
                HasColumnName("DateUpdated").
                HasColumnOrder(2).
                HasColumnType("date").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

            // Validation or just DB
         //   Property(p => p.PriceTotal).HasPrecision(8, 2);
            Ignore(c => c.PriceTotal);
            
          
            // For our Many<=>Many Relationship
            // Done
            HasMany( i => i.Ingredients).
                WithMany(r => r.RecipesWith).
                Map( m => 
                {
                    m.ToTable("RecipeIngredients");
                    m.MapLeftKey("RecipeId");
                    m.MapRightKey("IngredientId");
                });

            Map<Recipe>(m => m.ToTable("Recipes"));
        }

    }
}
