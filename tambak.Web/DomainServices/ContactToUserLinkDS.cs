
namespace tambak.Web.DomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using tambak.Web;


    // Implements application logic using the Entities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class ContactToUserLinkDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ContactToUserLinks' query.
        [Query(IsDefault = true)]
        public IQueryable<ContactToUserLink> GetContactToUserLinks()
        {
            return this.ObjectContext.ContactToUserLinks;
        }

        public void InsertContactToUserLink(ContactToUserLink contactToUserLink)
        {
            if ((contactToUserLink.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(contactToUserLink, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ContactToUserLinks.AddObject(contactToUserLink);
            }
        }

        public void UpdateContactToUserLink(ContactToUserLink currentContactToUserLink)
        {
            this.ObjectContext.ContactToUserLinks.AttachAsModified(currentContactToUserLink, this.ChangeSet.GetOriginal(currentContactToUserLink));
        }

        public void DeleteContactToUserLink(ContactToUserLink contactToUserLink)
        {
            if ((contactToUserLink.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(contactToUserLink, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ContactToUserLinks.Attach(contactToUserLink);
                this.ObjectContext.ContactToUserLinks.DeleteObject(contactToUserLink);
            }
        }
    }
}


