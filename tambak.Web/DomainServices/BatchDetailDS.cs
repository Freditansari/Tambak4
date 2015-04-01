
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
    public class BatchDetailDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'BatchDetails' query.
        [Query(IsDefault = true)]
        public IQueryable<BatchDetail> GetBatchDetails()
        {
            return this.ObjectContext.BatchDetails;
        }

        public void InsertBatchDetail(BatchDetail batchDetail)
        {
            if ((batchDetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchDetail, EntityState.Added);
            }
            else
            {
                this.ObjectContext.BatchDetails.AddObject(batchDetail);
            }
        }

        public void UpdateBatchDetail(BatchDetail currentBatchDetail)
        {
            this.ObjectContext.BatchDetails.AttachAsModified(currentBatchDetail, this.ChangeSet.GetOriginal(currentBatchDetail));
        }

        public void DeleteBatchDetail(BatchDetail batchDetail)
        {
            if ((batchDetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchDetail, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.BatchDetails.Attach(batchDetail);
                this.ObjectContext.BatchDetails.DeleteObject(batchDetail);
            }
        }
    }
}


