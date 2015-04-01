
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
    public class PODetailsViewsDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PODetailsViews' query.
        [Query(IsDefault = true)]
        public IQueryable<PODetailsView> GetPODetailsViews()
        {
            return this.ObjectContext.PODetailsViews;
        }

        public void InsertPODetailsView(PODetailsView pODetailsView)
        {
            if ((pODetailsView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODetailsView, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PODetailsViews.AddObject(pODetailsView);
            }
        }

        public void UpdatePODetailsView(PODetailsView currentPODetailsView)
        {
            this.ObjectContext.PODetailsViews.AttachAsModified(currentPODetailsView, this.ChangeSet.GetOriginal(currentPODetailsView));
        }

        public void DeletePODetailsView(PODetailsView pODetailsView)
        {
            if ((pODetailsView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(pODetailsView, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PODetailsViews.Attach(pODetailsView);
                this.ObjectContext.PODetailsViews.DeleteObject(pODetailsView);
            }
        }
    }
}


