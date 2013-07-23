using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SG.StateManagement;

namespace SG.Model
{

    // Share definition: A share is a pre-paid order for a certain amount of produce each week.
    // This class is used to build the UI. This class cannot be updated.
    public class ShareReference 
    {
       public virtual int ShareId { get; set; }
        public ShareType ShareSize;

        public string ShareDate { get; set; }
        public DayOfWeek Day { get; set; }

        // Use a ? so it is non nullable: Test This
        public Decimal? HalfSharePrice { get; set; }
        public Decimal? FullSharePrice { get; set; }
        public int Value { get; private set; }

         // Navigation Properties
        // Must be virtual to enable LazyLoading
        public virtual List<ShareLineItem> ShareLineItems { get; set; } 

        public State State { get; set; }


        public ShareReference()
        {
            ShareLineItems = new List<ShareLineItem>();
        }

    }


}
