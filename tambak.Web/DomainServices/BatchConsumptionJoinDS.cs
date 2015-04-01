
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
    public class BatchConsumptionJoinDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'BatchConsumptionJoins' query.
        [Query(IsDefault = true)]
        public IQueryable<BatchConsumptionJoin> GetBatchConsumptionJoins()
        {
            return this.ObjectContext.BatchConsumptionJoins;
        }

        public void InsertBatchConsumptionJoin(BatchConsumptionJoin batchConsumptionJoin)
        {
            if ((batchConsumptionJoin.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchConsumptionJoin, EntityState.Added);
            }
            else
            {
                this.ObjectContext.BatchConsumptionJoins.AddObject(batchConsumptionJoin);
            }
        }

        public void UpdateBatchConsumptionJoin(BatchConsumptionJoin currentBatchConsumptionJoin)
        {
            this.ObjectContext.BatchConsumptionJoins.AttachAsModified(currentBatchConsumptionJoin, this.ChangeSet.GetOriginal(currentBatchConsumptionJoin));
        }

        public void DeleteBatchConsumptionJoin(BatchConsumptionJoin batchConsumptionJoin)
        {
            if ((batchConsumptionJoin.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchConsumptionJoin, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.BatchConsumptionJoins.Attach(batchConsumptionJoin);
                this.ObjectContext.BatchConsumptionJoins.DeleteObject(batchConsumptionJoin);
            }
        }
    }
}


