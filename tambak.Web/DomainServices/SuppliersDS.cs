
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
    public class SuppliersDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Suppliers' query.
        [Query(IsDefault = true)]
        public IQueryable<Supplier> GetSuppliers()
        {
            return this.ObjectContext.Suppliers;
        }

        public void InsertSupplier(Supplier supplier)
        {
            if ((supplier.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(supplier, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Suppliers.AddObject(supplier);
            }
        }

        public void UpdateSupplier(Supplier currentSupplier)
        {
            this.ObjectContext.Suppliers.AttachAsModified(currentSupplier, this.ChangeSet.GetOriginal(currentSupplier));
        }

        public void DeleteSupplier(Supplier supplier)
        {
            if ((supplier.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(supplier, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Suppliers.Attach(supplier);
                this.ObjectContext.Suppliers.DeleteObject(supplier);
            }
        }
    }
}


