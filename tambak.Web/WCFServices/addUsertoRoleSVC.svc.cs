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
    public class addUsertoRoleSVC
    {
        [OperationContract]
        public void addUserToRole(string intendedUser, string intendedRole)
        {
            Roles.AddUserToRole(intendedUser, intendedRole);
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
