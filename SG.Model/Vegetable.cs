using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SG.StateManagement;

namespace SG.Model
{
    public class Vegetable : Produce
    {

    
        public virtual ICollection<Vegetable> VegiSubstitutions { get; set; }

      //  public State State { get; set; }

        public Vegetable()
        {
            
        }

    }
}
