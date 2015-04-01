
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
    public class CurrencyRateDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CurrencyRates' query.
        [Query(IsDefault = true)]
        public IQueryable<CurrencyRate> GetCurrencyRates()
        {
            return this.ObjectContext.CurrencyRates;
        }

        public void InsertCurrencyRate(CurrencyRate currencyRate)
        {
            if ((currencyRate.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(currencyRate, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CurrencyRates.AddObject(currencyRate);
            }
        }

        public void UpdateCurrencyRate(CurrencyRate currentCurrencyRate)
        {
            this.ObjectContext.CurrencyRates.AttachAsModified(currentCurrencyRate, this.ChangeSet.GetOriginal(currentCurrencyRate));
        }

        public void DeleteCurrencyRate(CurrencyRate currencyRate)
        {
            if ((currencyRate.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(currencyRate, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CurrencyRates.Attach(currencyRate);
                this.ObjectContext.CurrencyRates.DeleteObject(currencyRate);
            }
        }
    }
}


