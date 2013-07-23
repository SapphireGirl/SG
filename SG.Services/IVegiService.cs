using System.ServiceModel;
using SG.UserBoundedContext;
using SG.Model;

namespace SG.Services
{
    [ServiceContract]
    public interface IVegiService
    {
        [OperationContract]
        void GetLocalVegiPrices(Vegetable vegi);
    }
}
