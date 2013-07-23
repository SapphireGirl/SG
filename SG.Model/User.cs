using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG.StateManagement;
using System.Runtime.Serialization;

namespace SG.Model
{
    [DataContract]
    public class User : IObjectWithState, IObservable<User>
    {
         [DataMember]
        public virtual int UserId { get; set; }
         [DataMember]
        public string FirstName { get; set; }
         [DataMember]
        public string LastName { get; set; }
         [DataMember]
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName).Trim(); }
        }
         [DataMember]
        public DateTime DateCreated { get;  set; }
         [DataMember]
        public Address UserAddress { get; set; }

         [DataMember]
        public PersonalInfo Info { get; set; }
         [DataMember]
        public State State { get; set; }


        public User()
        {
         //   DateCreated = DateTime.Now;
            UserAddress = new Address();
            Info = new PersonalInfo();


        }

        public IDisposable Subscribe(IObserver<User> observer)
        {
            throw new NotImplementedException();
        }
    }
}
