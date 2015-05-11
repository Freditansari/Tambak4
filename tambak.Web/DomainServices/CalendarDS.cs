
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
    public class CalendarDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Calendars' query.
        [Query(IsDefault = true)]
        public IQueryable<Calendar> GetCalendars()
        {
            return this.ObjectContext.Calendars;
        }

        public void InsertCalendar(Calendar calendar)
        {
            if ((calendar.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(calendar, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Calendars.AddObject(calendar);
            }
        }

        public void UpdateCalendar(Calendar currentCalendar)
        {
            this.ObjectContext.Calendars.AttachAsModified(currentCalendar, this.ChangeSet.GetOriginal(currentCalendar));
        }

        public void DeleteCalendar(Calendar calendar)
        {
            if ((calendar.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(calendar, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Calendars.Attach(calendar);
                this.ObjectContext.Calendars.DeleteObject(calendar);
            }
        }
    }
}


