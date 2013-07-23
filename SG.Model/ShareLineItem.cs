using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using SG.StateManagement;


namespace SG.Model
{
    public class ShareLineItem : IObjectWithState
    {
        public virtual int ShareLineItemId { get; set; }

 
        public Share Share { get; set; }
        public int ShareId { get; set; }

        //public string Name { get; set { value = Produce.Name; }; }
       

        // This is either a fruit or a vegetable ID: Using Base Class
        public int LineProduceId { get; set; }

        [ForeignKey("LineProduceId")]
        public virtual Produce LineProduce { get; set; }

      
        public decimal LineTotal { get; set; }

        public State State { get; set; }


        public ShareLineItem()
        {
            //Produce = new Produce();

        }
    }
}
