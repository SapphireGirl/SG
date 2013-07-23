using SG.StateManagement;

namespace SG.Model
{
    public class PersonalInfo : IObjectWithState
    {
        public int PersonalInfoId { get; set; }
        public string Bio { get; set; }
        public string PoliticalAffiliation { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
       

        //Concurrency Token
        public int SocialSecurityNumber { get; set; }

        public State State { get; set; }

        public PersonalInfo()
        {
            
        }
    }

    //public enum PoliticalAffiliation
    //{
    //    Republican, Democrat, Independent
    //}
}
