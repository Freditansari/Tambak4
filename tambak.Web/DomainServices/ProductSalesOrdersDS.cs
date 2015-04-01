
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
    public class ProductSalesOrdersDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ProductSalesOrders' query.
        [Query(IsDefault = true)]
        public IQueryable<ProductSalesOrder> GetProductSalesOrders()
        {
            return this.ObjectContext.ProductSalesOrders;
        }

        public void InsertProductSalesOrder(ProductSalesOrder productSalesOrder)
        {
            if ((productSalesOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productSalesOrder, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ProductSalesOrders.AddObject(productSalesOrder);
            }
        }

        public void UpdateProductSalesOrder(ProductSalesOrder currentProductSalesOrder)
        {
            this.ObjectContext.ProductSalesOrders.AttachAsModified(currentProductSalesOrder, this.ChangeSet.GetOriginal(currentProductSalesOrder));
        }

        public void DeleteProductSalesOrder(ProductSalesOrder productSalesOrder)
        {
            if ((productSalesOrder.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productSalesOrder, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ProductSalesOrders.Attach(productSalesOrder);
                this.ObjectContext.ProductSalesOrders.DeleteObject(productSalesOrder);
            }
        }
    }
}


