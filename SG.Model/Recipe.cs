using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG.StateManagement;

namespace SG.Model
{
    public class Recipe : IObjectWithState
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        // Nullable
        public decimal? PriceTotal { get; set; }

        // Not creating a new Category every time because the
        // Category type might already exist
        //public string PrimaryCategoryCode { get; set; }
        //  public virtual List<Category> PrimaryCategories { get; set; }

        //public string SecondaryCategoryCode { get; set; }
        ////public virtual Category SecondaryCategory { get; set; }

        // This is a trick that EF uses to perform lazy loading from
        // a Dynamic proxy: pg 342
        // This is a navigation Property

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public State State { get; set; }
        // Constructors
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }

    }
}
