using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG.StateManagement;


namespace SG.Model
{
    public class Payment : IObjectWithState
    {
        public int PaymentId { get; set; }
        public State State { get; set; }

    }
}
