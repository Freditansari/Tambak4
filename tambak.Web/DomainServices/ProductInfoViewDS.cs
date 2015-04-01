
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
    public class ProductInfoViewDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ProductsInfoViews' query.
        [Query(IsDefault = true)]
        public IQueryable<ProductsInfoView> GetProductsInfoViews()
        {
            return this.ObjectContext.ProductsInfoViews;
        }

        public void InsertProductsInfoView(ProductsInfoView productsInfoView)
        {
            if ((productsInfoView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productsInfoView, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ProductsInfoViews.AddObject(productsInfoView);
            }
        }

        public void UpdateProductsInfoView(ProductsInfoView currentProductsInfoView)
        {
            this.ObjectContext.ProductsInfoViews.AttachAsModified(currentProductsInfoView, this.ChangeSet.GetOriginal(currentProductsInfoView));
        }

        public void DeleteProductsInfoView(ProductsInfoView productsInfoView)
        {
            if ((productsInfoView.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productsInfoView, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ProductsInfoViews.Attach(productsInfoView);
                this.ObjectContext.ProductsInfoViews.DeleteObject(productsInfoView);
            }
        }
    }
}


