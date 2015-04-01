
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
    public class UnitofMeasurementDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'UnitofMeasurements' query.
        [Query(IsDefault = true)]
        public IQueryable<UnitofMeasurement> GetUnitofMeasurements()
        {
            return this.ObjectContext.UnitofMeasurements;
        }

        public void InsertUnitofMeasurement(UnitofMeasurement unitofMeasurement)
        {
            if ((unitofMeasurement.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(unitofMeasurement, EntityState.Added);
            }
            else
            {
                this.ObjectContext.UnitofMeasurements.AddObject(unitofMeasurement);
            }
        }

        public void UpdateUnitofMeasurement(UnitofMeasurement currentUnitofMeasurement)
        {
            this.ObjectContext.UnitofMeasurements.AttachAsModified(currentUnitofMeasurement, this.ChangeSet.GetOriginal(currentUnitofMeasurement));
        }

        public void DeleteUnitofMeasurement(UnitofMeasurement unitofMeasurement)
        {
            if ((unitofMeasurement.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(unitofMeasurement, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.UnitofMeasurements.Attach(unitofMeasurement);
                this.ObjectContext.UnitofMeasurements.DeleteObject(unitofMeasurement);
            }
        }
    }
}


