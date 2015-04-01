
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
    public class AverageDailyFeedSummaryDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'AverageDailyFeedSummaries' query.
        [Query(IsDefault = true)]
        public IQueryable<AverageDailyFeedSummary> GetAverageDailyFeedSummaries()
        {
            return this.ObjectContext.AverageDailyFeedSummaries;
        }

    

        public void InsertAverageDailyFeedSummary(AverageDailyFeedSummary averageDailyFeedSummary)
        {
            if ((averageDailyFeedSummary.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(averageDailyFeedSummary, EntityState.Added);
            }
            else
            {
                this.ObjectContext.AverageDailyFeedSummaries.AddObject(averageDailyFeedSummary);
            }
        }

        public void UpdateAverageDailyFeedSummary(AverageDailyFeedSummary currentAverageDailyFeedSummary)
        {
            this.ObjectContext.AverageDailyFeedSummaries.AttachAsModified(currentAverageDailyFeedSummary, this.ChangeSet.GetOriginal(currentAverageDailyFeedSummary));
        }

        public void DeleteAverageDailyFeedSummary(AverageDailyFeedSummary averageDailyFeedSummary)
        {
            if ((averageDailyFeedSummary.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(averageDailyFeedSummary, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.AverageDailyFeedSummaries.Attach(averageDailyFeedSummary);
                this.ObjectContext.AverageDailyFeedSummaries.DeleteObject(averageDailyFeedSummary);
            }
        }
    }
}


