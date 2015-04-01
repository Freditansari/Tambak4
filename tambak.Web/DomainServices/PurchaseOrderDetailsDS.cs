
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
    public class PurchaseOrderDetailsDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PODetails' query.
        [Query(IsDefault = true)]
        public IQueryable<PODetail> GetPODetails()
        {
            return this.ObjectContext.PODetails;
        }

        public void InsertPODetail(PODetail pODetail)
        {
            if ((pODetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODetail, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PODetails.AddObject(pODetail);
            }
        }

        public void UpdatePODetail(PODetail currentPODetail)
        {
            this.ObjectContext.PODetails.AttachAsModified(currentPODetail, this.ChangeSet.GetOriginal(currentPODetail));
        }

        public void DeletePODetail(PODetail pODetail)
        {
            if ((pODetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODetail, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PODetails.Attach(pODetail);
                this.ObjectContext.PODetails.DeleteObject(pODetail);
            }
        }
    }
}


