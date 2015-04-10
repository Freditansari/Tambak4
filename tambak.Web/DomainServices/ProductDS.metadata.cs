
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


    // The MetadataTypeAttribute identifies ProductMetadata as the class
    // that carries additional metadata for the Product class.
    [MetadataTypeAttribute(typeof(Product.ProductMetadata))]
    public partial class Product
    {

        // This class allows you to attach custom attributes to properties
        // of the Product class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductMetadata()
            {
            }

            public EntityCollection<BatchDetail> BatchDetails { get; set; }

            public EntityCollection<BatchHeader> BatchHeaders { get; set; }

            public Nullable<int> Category { get; set; }

            public Category Category1 { get; set; }

            public EntityCollection<DeliveryLog> DeliveryLogs { get; set; }

            public EntityCollection<FeedingLog> FeedingLogs { get; set; }

            public Nullable<bool> IsFinishedProduct { get; set; }

            public EntityCollection<PODetail> PODetails { get; set; }

            public EntityCollection<PondConsumptionsLog> PondConsumptionsLogs { get; set; }

            public string Product_Description { get; set; }

            public int ProductID { get; set; }

            public string ProductName { get; set; }

            public EntityCollection<ProductPurchaseLog> ProductPurchaseLogs { get; set; }

            public EntityCollection<ProductQuantity> ProductQuantities { get; set; }

            public EntityCollection<ProductRequired> ProductRequireds { get; set; }

            public EntityCollection<ProductSalesOrder> ProductSalesOrders { get; set; }

            public EntityCollection<ProductsDetail> ProductsDetails { get; set; }

            public Nullable<decimal> PurchasePrice { get; set; }

            public Nullable<decimal> qtyperunit { get; set; }

            public Nullable<decimal> ReorderLevel { get; set; }

            public Nullable<decimal> SalePrice { get; set; }

            public string SKU { get; set; }

            public Nullable<decimal> UnitInOrder { get; set; }

            public Nullable<decimal> UnitInStock { get; set; }

            public string Uom { get; set; }
        }
    }
}
