using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using SG.StateManagement;

namespace SG.Model
{
    public class Fruit : Produce
    {

        public virtual ICollection<Fruit> FruitSubstitutions { get; set; }

       // public State State { get; set; }

        public Fruit()
        {
            
        }
    }
}
