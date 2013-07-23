using System.ComponentModel.DataAnnotations;


namespace SG.Model
{
    // A Complex Type is a value type within another entity type.
    // Here, Address is used with in the User class.
    // Code First convention is such that a Complex type does not have an
    // identity
    // A complex type is dependent on the Host type for change tracking and persistance
    // Configurations are done in the Parent class
    // User
 // [ComplexType]
    public class Address 
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
            // Used for State
        public string Region { get; set; }
        public string ZipCode { get; set; }
  }
}