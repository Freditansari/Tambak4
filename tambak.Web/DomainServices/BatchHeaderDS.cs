
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
    public class BatchHeaderDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'BatchHeaders' query.
        [Query(IsDefault = true)]
        public IQueryable<BatchHeader> GetBatchHeaders()
        {
            return this.ObjectContext.BatchHeaders;
        }

        public void InsertBatchHeader(BatchHeader batchHeader)
        {
            if ((batchHeader.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchHeader, EntityState.Added);
            }
            else
            {
                this.ObjectContext.BatchHeaders.AddObject(batchHeader);
            }
        }

        public void UpdateBatchHeader(BatchHeader currentBatchHeader)
        {
            this.ObjectContext.BatchHeaders.AttachAsModified(currentBatchHeader, this.ChangeSet.GetOriginal(currentBatchHeader));
        }

        public void DeleteBatchHeader(BatchHeader batchHeader)
        {
            if ((batchHeader.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchHeader, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.BatchHeaders.Attach(batchHeader);
                this.ObjectContext.BatchHeaders.DeleteObject(batchHeader);
            }
        }
    }
}


