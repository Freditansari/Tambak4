
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
    public class FacilityDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Facilities' query.
        [Query(IsDefault = true)]
        public IQueryable<Facility> GetFacilities()
        {
            return this.ObjectContext.Facilities;
        }

        public void InsertFacility(Facility facility)
        {
            if ((facility.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(facility, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Facilities.AddObject(facility);
            }
        }

        public void UpdateFacility(Facility currentFacility)
        {
            this.ObjectContext.Facilities.AttachAsModified(currentFacility, this.ChangeSet.GetOriginal(currentFacility));
        }

        public void DeleteFacility(Facility facility)
        {
            if ((facility.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(facility, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Facilities.Attach(facility);
                this.ObjectContext.Facilities.DeleteObject(facility);
            }
        }
    }
}


