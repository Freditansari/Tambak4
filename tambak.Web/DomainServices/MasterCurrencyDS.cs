
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
    public class MasterCurrencyDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'MasterCurrencies' query.
        [Query(IsDefault = true)]
        public IQueryable<MasterCurrency> GetMasterCurrencies()
        {
            return this.ObjectContext.MasterCurrencies;
        }

        public IQueryable<MasterCurrency> GetDefaultMasterCurrencies()
        {
            return this.ObjectContext.MasterCurrencies.OrderByDescending(b => b.isDefault);
        }

        public void InsertMasterCurrency(MasterCurrency masterCurrency)
        {
            if ((masterCurrency.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(masterCurrency, EntityState.Added);
            }
            else
            {
                this.ObjectContext.MasterCurrencies.AddObject(masterCurrency);
            }
        }

        public void UpdateMasterCurrency(MasterCurrency currentMasterCurrency)
        {
            this.ObjectContext.MasterCurrencies.AttachAsModified(currentMasterCurrency, this.ChangeSet.GetOriginal(currentMasterCurrency));
        }

        public void DeleteMasterCurrency(MasterCurrency masterCurrency)
        {
            if ((masterCurrency.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(masterCurrency, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.MasterCurrencies.Attach(masterCurrency);
                this.ObjectContext.MasterCurrencies.DeleteObject(masterCurrency);
            }
        }
    }
}


