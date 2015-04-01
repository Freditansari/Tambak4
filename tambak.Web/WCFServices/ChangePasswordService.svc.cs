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
    public class ChangePasswordService
    {
        [OperationContract]
        public bool UserChangePassword(string userName, string oldPassword, string newPassword)
        {
            if (Membership.ValidateUser(userName, oldPassword))
            {
                MembershipUser memUser = Membership.GetUser(userName);
                return memUser.ChangePassword(oldPassword, newPassword);
            }
            return false;
        } 
        // Add more operations here and mark them with [OperationContract]
    }
}
