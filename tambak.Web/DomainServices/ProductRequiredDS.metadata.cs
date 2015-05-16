
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


    // The MetadataTypeAttribute identifies ProductRequiredMetadata as the class
    // that carries additional metadata for the ProductRequired class.
    [MetadataTypeAttribute(typeof(ProductRequired.ProductRequiredMetadata))]
    public partial class ProductRequired
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductRequired class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductRequiredMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductRequiredMetadata()
            {
            }

            [Required]
            public Nullable<decimal> Amount { get; set; }

            public Product Product { get; set; }

            public Nullable<int> ProductID { get; set; }

            public EntityCollection<ProductSalesOrder> ProductSalesOrders { get; set; }

            public int RequirementID { get; set; }

            public Task Task { get; set; }

            public Nullable<int> TaskID { get; set; }
        }
    }
}
