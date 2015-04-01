
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
    public class SamplingLogDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'SamplingLogs' query.
        [Query(IsDefault = true)]
        public IQueryable<SamplingLog> GetSamplingLogs()
        {
            return this.ObjectContext.SamplingLogs;
        }

        public void InsertSamplingLog(SamplingLog samplingLog)
        {
            if ((samplingLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(samplingLog, EntityState.Added);
            }
            else
            {
                this.ObjectContext.SamplingLogs.AddObject(samplingLog);
            }
        }

        public void UpdateSamplingLog(SamplingLog currentSamplingLog)
        {
            this.ObjectContext.SamplingLogs.AttachAsModified(currentSamplingLog, this.ChangeSet.GetOriginal(currentSamplingLog));
        }

        public void DeleteSamplingLog(SamplingLog samplingLog)
        {
            if ((samplingLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(samplingLog, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.SamplingLogs.Attach(samplingLog);
                this.ObjectContext.SamplingLogs.DeleteObject(samplingLog);
            }
        }
    }
}


