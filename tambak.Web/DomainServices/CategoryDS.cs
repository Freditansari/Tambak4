
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
    public class CategoryDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Categories' query.
        [Query(IsDefault = true)]
        public IQueryable<Category> GetCategories()
        {
            return this.ObjectContext.Categories;
        }

        public void InsertCategory(Category category)
        {
            if ((category.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(category, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Categories.AddObject(category);
            }
        }

        public void UpdateCategory(Category currentCategory)
        {
            this.ObjectContext.Categories.AttachAsModified(currentCategory, this.ChangeSet.GetOriginal(currentCategory));
        }

        public void DeleteCategory(Category category)
        {
            if ((category.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(category, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Categories.Attach(category);
                this.ObjectContext.Categories.DeleteObject(category);
            }
        }
    }
}


