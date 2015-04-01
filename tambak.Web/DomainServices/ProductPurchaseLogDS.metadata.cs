
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ProductPurchaseLogMetadata as the class
    // that carries additional metadata for the ProductPurchaseLog class.
    [MetadataTypeAttribute(typeof(ProductPurchaseLog.ProductPurchaseLogMetadata))]
    public partial class ProductPurchaseLog
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductPurchaseLog class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductPurchaseLogMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductPurchaseLogMetadata()
            {
            }

            public string batchID { get; set; }

            public string Currency { get; set; }

            public Nullable<DateTime> Date { get; set; }

            public Nullable<DateTime> ExpireDate { get; set; }

            public Nullable<bool> isDelivered { get; set; }

            public Nullable<bool> isSynchronized { get; set; }

            public string location { get; set; }

            public Product Product { get; set; }

            public int ProductID { get; set; }

            public EntityCollection<ProductQuantity> ProductQuantities { get; set; }

            public int PurchaseLogID { get; set; }

            public Nullable<decimal> PurchasePrice { get; set; }

            public Nullable<int> Quantity { get; set; }

            public string Requester { get; set; }

            public Nullable<decimal> Shipping { get; set; }

            public Nullable<decimal> tax { get; set; }

            public Nullable<decimal> Total { get; set; }

            public string userID { get; set; }
        }
    }
}
