
namespace tambak.Web
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


    // Implements application logic using the Entities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class SumProductRequiredViewDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'SumProductRequiredViews' query.
        [Query(IsDefault = true)]
        public IQueryable<SumProductRequiredView> GetSumProductRequiredViews()
        {
            return this.ObjectContext.SumProductRequiredViews;
        }

        public void InsertSumProductRequiredView(SumProductRequiredView sumProductRequiredView)
        {
            if ((sumProductRequiredView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sumProductRequiredView, EntityState.Added);
            }
            else
            {
                this.ObjectContext.SumProductRequiredViews.AddObject(sumProductRequiredView);
            }
        }

        public void UpdateSumProductRequiredView(SumProductRequiredView currentSumProductRequiredView)
        {
            this.ObjectContext.SumProductRequiredViews.AttachAsModified(currentSumProductRequiredView, this.ChangeSet.GetOriginal(currentSumProductRequiredView));
        }

        public void DeleteSumProductRequiredView(SumProductRequiredView sumProductRequiredView)
        {
            if ((sumProductRequiredView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sumProductRequiredView, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.SumProductRequiredViews.Attach(sumProductRequiredView);
                this.ObjectContext.SumProductRequiredViews.DeleteObject(sumProductRequiredView);
            }
        }
    }
}


