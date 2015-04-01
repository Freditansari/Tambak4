
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
    public class BatchQuantityViewDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'batchQuantityViews' query.
        [Query(IsDefault = true)]
        public IQueryable<batchQuantityView> GetBatchQuantityViews()
        {
            return this.ObjectContext.batchQuantityViews.Where(b => b.Unit_Available > 0);
        }

        public void InsertBatchQuantityView(batchQuantityView batchQuantityView)
        {
            if ((batchQuantityView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchQuantityView, EntityState.Added);
            }
            else
            {
                this.ObjectContext.batchQuantityViews.AddObject(batchQuantityView);
            }
        }

        public void UpdateBatchQuantityView(batchQuantityView currentbatchQuantityView)
        {
            this.ObjectContext.batchQuantityViews.AttachAsModified(currentbatchQuantityView, this.ChangeSet.GetOriginal(currentbatchQuantityView));
        }

        public void DeleteBatchQuantityView(batchQuantityView batchQuantityView)
        {
            if ((batchQuantityView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(batchQuantityView, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.batchQuantityViews.Attach(batchQuantityView);
                this.ObjectContext.batchQuantityViews.DeleteObject(batchQuantityView);
            }
        }
    }
}


