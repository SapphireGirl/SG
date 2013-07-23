using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SG.Mapping;
using SG.Model;
using SG.StateManagement;

namespace SG.RecipeBoundedContext
{
    public class RecipeContext : BaseContext<RecipeContext>
    {
        public  DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }


        public RecipeContext()
        {
            ((IObjectContextAdapter)this).ObjectContext
              .ObjectMaterialized += (sender, args) =>
              {
                  var entity = args.Entity as IObjectWithState;
                  if (entity != null)
                  {
                      entity.State = State.Unchanged;
                  }
              };
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Configurations.Add(new RecipeConfig());
            modelBuilder.Configurations.Add(new IngredientConfig());

        } 

    }
}
