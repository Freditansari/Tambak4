
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
    public class WaterParameterLogDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'WaterParameterLogs' query.
        [Query(IsDefault = true)]
        public IQueryable<WaterParameterLog> GetWaterParameterLogs()
        {
            return this.ObjectContext.WaterParameterLogs;
        }

        public void InsertWaterParameterLog(WaterParameterLog waterParameterLog)
        {
            if ((waterParameterLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(waterParameterLog, EntityState.Added);
            }
            else
            {
                this.ObjectContext.WaterParameterLogs.AddObject(waterParameterLog);
            }
        }

        public void UpdateWaterParameterLog(WaterParameterLog currentWaterParameterLog)
        {
            this.ObjectContext.WaterParameterLogs.AttachAsModified(currentWaterParameterLog, this.ChangeSet.GetOriginal(currentWaterParameterLog));
        }

        public void DeleteWaterParameterLog(WaterParameterLog waterParameterLog)
        {
            if ((waterParameterLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(waterParameterLog, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.WaterParameterLogs.Attach(waterParameterLog);
                this.ObjectContext.WaterParameterLogs.DeleteObject(waterParameterLog);
            }
        }
    }
}


