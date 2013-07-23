using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.Model
{
    public class Store
    {
        public string Name { get; set; }
        public Address StoreAddress { get; set; }

        public Store()
        {
            StoreAddress = new Address();
        }
    }
}
