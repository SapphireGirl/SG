using System;
using System.Collections.Generic;
using System.Data.Entity;
using SG.Model;


namespace SG.RecipeBoundedContext 
{
    public class InitializeSGRecipeDatabaseWithSeedData : DropCreateDatabaseAlways<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {
            base.Seed(context);
        }
    }
}
