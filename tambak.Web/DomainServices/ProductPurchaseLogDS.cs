
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
    public class ProductPurchaseLogDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ProductPurchaseLogs' query.
        [Query(IsDefault = true)]
        public IQueryable<ProductPurchaseLog> GetProductPurchaseLogs()
        {
            return this.ObjectContext.ProductPurchaseLogs;
        }

        public void InsertProductPurchaseLog(ProductPurchaseLog productPurchaseLog)
        {
            if ((productPurchaseLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productPurchaseLog, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ProductPurchaseLogs.AddObject(productPurchaseLog);
            }
        }

        public void UpdateProductPurchaseLog(ProductPurchaseLog currentProductPurchaseLog)
        {
            this.ObjectContext.ProductPurchaseLogs.AttachAsModified(currentProductPurchaseLog, this.ChangeSet.GetOriginal(currentProductPurchaseLog));
        }

        public void DeleteProductPurchaseLog(ProductPurchaseLog productPurchaseLog)
        {
            if ((productPurchaseLog.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productPurchaseLog, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ProductPurchaseLogs.Attach(productPurchaseLog);
                this.ObjectContext.ProductPurchaseLogs.DeleteObject(productPurchaseLog);
            }
        }
    }
}


