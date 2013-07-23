using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG.StateManagement;


namespace SG.Model
{
    public abstract class Produce : IObjectWithState
    {

        public virtual int ProduceId { get; set; }
        public virtual string Name { get; set; }
        public decimal? PricePerEach { get; set; }
        public decimal? PricePerFlat { get; set; }
        public decimal? PricePerPound { get; set; }

        public State State { get; set; }

        public Produce()
        {
           
        }
    }
}
