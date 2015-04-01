
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PODetailMetadata as the class
    // that carries additional metadata for the PODetail class.
    [MetadataTypeAttribute(typeof(PODetail.PODetailMetadata))]
    public partial class PODetail
    {

        // This class allows you to attach custom attributes to properties
        // of the PODetail class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PODetailMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PODetailMetadata()
            {
            }

            public string Description { get; set; }

            public int PODetailsID { get; set; }

            public string POID { get; set; }

            public Product Product { get; set; }

            public int ProductID { get; set; }

            public PurchaseOrder PurchaseOrder { get; set; }

            public Nullable<decimal> qty { get; set; }

            public Nullable<decimal> Total { get; set; }

            public Nullable<decimal> UnitPrice { get; set; }
        }
    }
}
