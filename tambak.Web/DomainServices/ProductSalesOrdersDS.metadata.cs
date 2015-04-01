
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ProductSalesOrderMetadata as the class
    // that carries additional metadata for the ProductSalesOrder class.
    [MetadataTypeAttribute(typeof(ProductSalesOrder.ProductSalesOrderMetadata))]
    public partial class ProductSalesOrder
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductSalesOrder class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductSalesOrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductSalesOrderMetadata()
            {
            }

            public Contact Contact { get; set; }

            public Nullable<int> LotNumber { get; set; }

            public Nullable<decimal> Price { get; set; }

            public Product Product { get; set; }

            public Nullable<int> ProductID { get; set; }

           // public ProductQuantity ProductQuantity { get; set; }

            public ProductRequired ProductRequired { get; set; }

            public Nullable<decimal> QTY { get; set; }

            public Nullable<int> RequirementID { get; set; }

            public int SalesOrderID { get; set; }

            public Task Task { get; set; }

            public Nullable<int> TaskID { get; set; }

            public Nullable<decimal> total { get; set; }

            public Nullable<DateTime> trxDate { get; set; }

            public string UserID { get; set; }

            public Nullable<int> UserPicked { get; set; }

            public string userPickedName { get; set; }
        }
    }
}
