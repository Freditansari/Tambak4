using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Security;
using System.Collections.Generic;


namespace tambak.Web.WCFServices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class getAllUsersService
    {
        [OperationContract]
        public List<String> getUsers()
        {
            // Add your operation implementation here
            List<String> userLists = new List<String>();
            //userLists.Add( Membership.GetAllUsers().ToString());
            foreach (MembershipUser element in Membership.GetAllUsers())
            {
                userLists.Add(element.ToString());
            }
            return userLists;
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
