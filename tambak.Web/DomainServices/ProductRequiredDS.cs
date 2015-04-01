
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
    public class ProductRequiredDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ProductRequireds' query.
        [Query(IsDefault = true)]
        public IQueryable<ProductRequired> GetProductRequireds()
        {
            return this.ObjectContext.ProductRequireds;
        }

        public void InsertProductRequired(ProductRequired productRequired)
        {
            if ((productRequired.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productRequired, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ProductRequireds.AddObject(productRequired);
            }
        }

        public void UpdateProductRequired(ProductRequired currentProductRequired)
        {
            this.ObjectContext.ProductRequireds.AttachAsModified(currentProductRequired, this.ChangeSet.GetOriginal(currentProductRequired));
        }

        public void DeleteProductRequired(ProductRequired productRequired)
        {
            if ((productRequired.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productRequired, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ProductRequireds.Attach(productRequired);
                this.ObjectContext.ProductRequireds.DeleteObject(productRequired);
            }
        }
    }
}


