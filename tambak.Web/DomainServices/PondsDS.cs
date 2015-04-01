
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
    public class PondsDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Ponds' query.
        [Query(IsDefault = true)]
        public IQueryable<Pond> GetPonds()
        {
            return this.ObjectContext.Ponds;
        }

        public void InsertPond(Pond pond)
        {
            if ((pond.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pond, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Ponds.AddObject(pond);
            }
        }

        public void UpdatePond(Pond currentPond)
        {
            this.ObjectContext.Ponds.AttachAsModified(currentPond, this.ChangeSet.GetOriginal(currentPond));
        }

        public void DeletePond(Pond pond)
        {
            if ((pond.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pond, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Ponds.Attach(pond);
                this.ObjectContext.Ponds.DeleteObject(pond);
            }
        }
    }
}


