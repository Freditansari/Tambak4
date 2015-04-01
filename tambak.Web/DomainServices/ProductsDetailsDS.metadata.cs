
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ProductsDetailMetadata as the class
    // that carries additional metadata for the ProductsDetail class.
    [MetadataTypeAttribute(typeof(ProductsDetail.ProductsDetailMetadata))]
    public partial class ProductsDetail
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductsDetail class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductsDetailMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductsDetailMetadata()
            {
            }

            public string Description { get; set; }

            public Nullable<int> Ordered { get; set; }

            public Product Product { get; set; }

            public int ProductID { get; set; }

            public int ProductTrxID { get; set; }

            public Nullable<int> received { get; set; }

            public Nullable<int> shrinkage { get; set; }

            public Nullable<int> sold { get; set; }

            public Nullable<int> trxDate { get; set; }

            public string UserID { get; set; }
        }
    }
}
