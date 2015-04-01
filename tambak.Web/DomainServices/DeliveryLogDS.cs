
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
    public class DeliveryLogDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'DeliveryLogs' query.
        [Query(IsDefault = true)]
        public IQueryable<DeliveryLog> GetDeliveryLogs()
        {
            return this.ObjectContext.DeliveryLogs;
        }

        public void InsertDeliveryLog(DeliveryLog deliveryLog)
        {
            if ((deliveryLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(deliveryLog, EntityState.Added);
            }
            else
            {
                this.ObjectContext.DeliveryLogs.AddObject(deliveryLog);
            }
        }

        public void UpdateDeliveryLog(DeliveryLog currentDeliveryLog)
        {
            this.ObjectContext.DeliveryLogs.AttachAsModified(currentDeliveryLog, this.ChangeSet.GetOriginal(currentDeliveryLog));
        }

        public void DeleteDeliveryLog(DeliveryLog deliveryLog)
        {
            if ((deliveryLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(deliveryLog, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.DeliveryLogs.Attach(deliveryLog);
                this.ObjectContext.DeliveryLogs.DeleteObject(deliveryLog);
            }
        }
    }
}


