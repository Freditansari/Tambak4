using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace tambak.Web.WCFServices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GetServerTime
    {
        [OperationContract]
        public DateTime getServerTime()
        {
            return DateTime.Now;

        }

        // Add more operations here and mark them with [OperationContract]
    }
}
