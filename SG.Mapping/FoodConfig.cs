using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class FoodConfig :  EntityTypeConfiguration<Produce>
    {
        public FoodConfig()
        {
            // You don't need this class
        }
    }
}
