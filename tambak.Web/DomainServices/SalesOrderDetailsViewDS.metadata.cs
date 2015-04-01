
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies SalesOrderDetailsViewMetadata as the class
    // that carries additional metadata for the SalesOrderDetailsView class.
    [MetadataTypeAttribute(typeof(SalesOrderDetailsView.SalesOrderDetailsViewMetadata))]
    public partial class SalesOrderDetailsView
    {

        // This class allows you to attach custom attributes to properties
        // of the SalesOrderDetailsView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SalesOrderDetailsViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SalesOrderDetailsViewMetadata()
            {
            }

            public Nullable<decimal> Discount { get; set; }

            public Nullable<decimal> price { get; set; }

            public int ProductId { get; set; }

            public string ProductName { get; set; }

            public Nullable<decimal> qty { get; set; }

            public int salesOrderDetailID { get; set; }

            public Nullable<int> SalesOrderHeaderID { get; set; }

            public Nullable<decimal> Total { get; set; }
        }
    }
}
