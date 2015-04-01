
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
    public class ProductRequiredViewDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ProductRequiredViews' query.
        [Query(IsDefault = true)]
        public IQueryable<ProductRequiredView> GetProductRequiredViews()
        {
            return this.ObjectContext.ProductRequiredViews;
        }

        public void InsertProductRequiredView(ProductRequiredView productRequiredView)
        {
            if ((productRequiredView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productRequiredView, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ProductRequiredViews.AddObject(productRequiredView);
            }
        }

        public void UpdateProductRequiredView(ProductRequiredView currentProductRequiredView)
        {
            this.ObjectContext.ProductRequiredViews.AttachAsModified(currentProductRequiredView, this.ChangeSet.GetOriginal(currentProductRequiredView));
        }

        public void DeleteProductRequiredView(ProductRequiredView productRequiredView)
        {
            if ((productRequiredView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productRequiredView, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ProductRequiredViews.Attach(productRequiredView);
                this.ObjectContext.ProductRequiredViews.DeleteObject(productRequiredView);
            }
        }
    }
}


