
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
    public class CompanyDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Companies' query.
        [Query(IsDefault = true)]
        public IQueryable<Company> GetCompanies()
        {
            return this.ObjectContext.Companies;
        }

        public void InsertCompany(Company company)
        {
            if ((company.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(company, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Companies.AddObject(company);
            }
        }

        public void UpdateCompany(Company currentCompany)
        {
            this.ObjectContext.Companies.AttachAsModified(currentCompany, this.ChangeSet.GetOriginal(currentCompany));
        }

        public void DeleteCompany(Company company)
        {
            if ((company.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(company, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Companies.Attach(company);
                this.ObjectContext.Companies.DeleteObject(company);
            }
        }
    }
}


