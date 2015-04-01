
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
    public class PDOControlDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PDOControls' query.
        [Query(IsDefault = true)]
        public IQueryable<PDOControl> GetPDOControls()
        {
            return this.ObjectContext.PDOControls;
        }

        public void InsertPDOControl(PDOControl pDOControl)
        {
            if ((pDOControl.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pDOControl, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PDOControls.AddObject(pDOControl);
            }
        }

        public void UpdatePDOControl(PDOControl currentPDOControl)
        {
            this.ObjectContext.PDOControls.AttachAsModified(currentPDOControl, this.ChangeSet.GetOriginal(currentPDOControl));
        }

        public void DeletePDOControl(PDOControl pDOControl)
        {
            if ((pDOControl.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pDOControl, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PDOControls.Attach(pDOControl);
                this.ObjectContext.PDOControls.DeleteObject(pDOControl);
            }
        }
    }
}


