
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
    public class ContactDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Contacts' query.
        [Query(IsDefault = true)]
        public IQueryable<Contact> GetContacts()
        {
            return this.ObjectContext.Contacts;
        }

        public void InsertContact(Contact contact)
        {
            if ((contact.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(contact, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Contacts.AddObject(contact);
            }
        }

        public void UpdateContact(Contact currentContact)
        {
            this.ObjectContext.Contacts.AttachAsModified(currentContact, this.ChangeSet.GetOriginal(currentContact));
        }

        public void DeleteContact(Contact contact)
        {
            if ((contact.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(contact, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Contacts.Attach(contact);
                this.ObjectContext.Contacts.DeleteObject(contact);
            }
        }
    }
}


