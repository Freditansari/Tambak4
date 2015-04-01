
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
    public class PODeliveredQuantityDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PODeliveredQuantities' query.
        [Query(IsDefault = true)]
        public IQueryable<PODeliveredQuantity> GetPODeliveredQuantities()
        {
            return this.ObjectContext.PODeliveredQuantities;
        }

        public void InsertPODeliveredQuantity(PODeliveredQuantity pODeliveredQuantity)
        {
            if ((pODeliveredQuantity.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODeliveredQuantity, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PODeliveredQuantities.AddObject(pODeliveredQuantity);
            }
        }

        public void UpdatePODeliveredQuantity(PODeliveredQuantity currentPODeliveredQuantity)
        {
            this.ObjectContext.PODeliveredQuantities.AttachAsModified(currentPODeliveredQuantity, this.ChangeSet.GetOriginal(currentPODeliveredQuantity));
        }

        public void DeletePODeliveredQuantity(PODeliveredQuantity pODeliveredQuantity)
        {
            if ((pODeliveredQuantity.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODeliveredQuantity, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PODeliveredQuantities.Attach(pODeliveredQuantity);
                this.ObjectContext.PODeliveredQuantities.DeleteObject(pODeliveredQuantity);
            }
        }
    }
}


