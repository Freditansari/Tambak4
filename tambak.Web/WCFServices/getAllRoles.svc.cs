using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Security;

namespace tambak.Web.WCFServices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class getAllRoles
    {
        [OperationContract]
        public string[] getRoles()
        {
            // Add your operation implementation here
            return Roles.GetAllRoles();
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
