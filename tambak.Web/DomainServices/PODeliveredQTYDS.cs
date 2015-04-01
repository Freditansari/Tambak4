
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
    public class PODeliveredQTYDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PODeliveredQties' query.
        [Query(IsDefault = true)]
        public IQueryable<PODeliveredQty> GetPODeliveredQties()
        {
            return this.ObjectContext.PODeliveredQties;
        }

        public void InsertPODeliveredQty(PODeliveredQty pODeliveredQty)
        {
            if ((pODeliveredQty.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODeliveredQty, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PODeliveredQties.AddObject(pODeliveredQty);
            }
        }

        public void UpdatePODeliveredQty(PODeliveredQty currentPODeliveredQty)
        {
            this.ObjectContext.PODeliveredQties.AttachAsModified(currentPODeliveredQty, this.ChangeSet.GetOriginal(currentPODeliveredQty));
        }

        public void DeletePODeliveredQty(PODeliveredQty pODeliveredQty)
        {
            if ((pODeliveredQty.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODeliveredQty, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PODeliveredQties.Attach(pODeliveredQty);
                this.ObjectContext.PODeliveredQties.DeleteObject(pODeliveredQty);
            }
        }
    }
}


