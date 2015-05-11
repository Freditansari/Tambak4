
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
    public class FeedingTrayDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'FeedingTrays' query.
        [Query(IsDefault = true)]
        public IQueryable<FeedingTray> GetFeedingTrays()
        {
            return this.ObjectContext.FeedingTrays;
        }

        public void InsertFeedingTray(FeedingTray feedingTray)
        {
            if ((feedingTray.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(feedingTray, EntityState.Added);
            }
            else
            {
                this.ObjectContext.FeedingTrays.AddObject(feedingTray);
            }
        }

        public void UpdateFeedingTray(FeedingTray currentFeedingTray)
        {
            this.ObjectContext.FeedingTrays.AttachAsModified(currentFeedingTray, this.ChangeSet.GetOriginal(currentFeedingTray));
        }

        public void DeleteFeedingTray(FeedingTray feedingTray)
        {
            if ((feedingTray.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(feedingTray, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.FeedingTrays.Attach(feedingTray);
                this.ObjectContext.FeedingTrays.DeleteObject(feedingTray);
            }
        }
    }
}


