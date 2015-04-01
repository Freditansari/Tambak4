
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
    public class PurchaseTaxTransactionsDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'PurchaseTaxTransactions' query.
        [Query(IsDefault = true)]
        public IQueryable<PurchaseTaxTransaction> GetPurchaseTaxTransactions()
        {
            return this.ObjectContext.PurchaseTaxTransactions;
        }

        public void InsertPurchaseTaxTransaction(PurchaseTaxTransaction purchaseTaxTransaction)
        {
            if ((purchaseTaxTransaction.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaseTaxTransaction, EntityState.Added);
            }
            else
            {
                this.ObjectContext.PurchaseTaxTransactions.AddObject(purchaseTaxTransaction);
            }
        }

        public void UpdatePurchaseTaxTransaction(PurchaseTaxTransaction currentPurchaseTaxTransaction)
        {
            this.ObjectContext.PurchaseTaxTransactions.AttachAsModified(currentPurchaseTaxTransaction, this.ChangeSet.GetOriginal(currentPurchaseTaxTransaction));
        }

        public void DeletePurchaseTaxTransaction(PurchaseTaxTransaction purchaseTaxTransaction)
        {
            if ((purchaseTaxTransaction.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(purchaseTaxTransaction, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.PurchaseTaxTransactions.Attach(purchaseTaxTransaction);
                this.ObjectContext.PurchaseTaxTransactions.DeleteObject(purchaseTaxTransaction);
            }
        }
    }
}


