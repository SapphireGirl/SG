using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SG.StateManagement;


namespace SG.Model
{
    public class Ingredient : IObjectWithState
    {
        public int IngredientId { get; set; }

       
        public string Name { get; set; }
        public decimal? Cost { get; set; }

        public string Unit { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
       

        public State State { get; set; }
        //  public Uri IngredientProfilePage;

     
        // Navigation Property
        public virtual ICollection<Recipe> RecipesWith { get; set; }

        public Ingredient()
        {
            RecipesWith = new List<Recipe>();
        }

    }
}
