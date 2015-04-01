
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
    public class PurchaseOrderHeaderDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PurchaseOrders' query.
        [Query(IsDefault = true)]
        public IQueryable<PurchaseOrder> GetPurchaseOrders()
        {
            return this.ObjectContext.PurchaseOrders;
        }

        public IQueryable<PurchaseOrder> GetisNotCompletePurchaseOrders()
        {
            return this.ObjectContext.PurchaseOrders.Where(b => b.isComplete==false);
        }

        public void InsertPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if ((purchaseOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaseOrder, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PurchaseOrders.AddObject(purchaseOrder);
            }
        }

        public void UpdatePurchaseOrder(PurchaseOrder currentPurchaseOrder)
        {
            this.ObjectContext.PurchaseOrders.AttachAsModified(currentPurchaseOrder, this.ChangeSet.GetOriginal(currentPurchaseOrder));
        }

        public void DeletePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            if ((purchaseOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaseOrder, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PurchaseOrders.Attach(purchaseOrder);
                this.ObjectContext.PurchaseOrders.DeleteObject(purchaseOrder);
            }
        }
    }
}


