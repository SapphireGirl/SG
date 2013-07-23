using SG.StateManagement;

namespace SG.Model
{
    // Might need to change this class as we go
    // Could be an enum or the other way, could have
    // a collection of recipes or ingredients
    public class Category : IObjectWithState
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }


        public State State { get; set; }
       
        
    }
}
