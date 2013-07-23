using System.ComponentModel.DataAnnotations;
using SG.StateManagement;

namespace SG.Model
{
    public class Coop : IObjectWithState
    {
        public virtual int CoopId { get; set; }
        public string Name { get; set; }

        public Address CoopAddress { get; set; }

        public State State { get; set; }

        public Coop()
        {

            CoopAddress = new Address();
        }


        
    }
}
