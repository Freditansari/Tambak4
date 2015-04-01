
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
    public class HarvestDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Harvests' query.
        [Query(IsDefault = true)]
        public IQueryable<Harvest> GetHarvests()
        {
            return this.ObjectContext.Harvests;
        }

        public void InsertHarvest(Harvest harvest)
        {
            if ((harvest.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(harvest, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Harvests.AddObject(harvest);
            }
        }

        public void UpdateHarvest(Harvest currentHarvest)
        {
            this.ObjectContext.Harvests.AttachAsModified(currentHarvest, this.ChangeSet.GetOriginal(currentHarvest));
        }

        public void DeleteHarvest(Harvest harvest)
        {
            if ((harvest.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(harvest, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Harvests.Attach(harvest);
                this.ObjectContext.Harvests.DeleteObject(harvest);
            }
        }
    }
}


