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
    public class addRoleService
    {
        [OperationContract]
        public void addRoles(string intendedRole)
        {
            Roles.CreateRole(intendedRole);
        }

        
    }
}
