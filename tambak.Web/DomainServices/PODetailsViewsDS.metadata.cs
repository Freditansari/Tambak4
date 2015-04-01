
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PODetailsViewMetadata as the class
    // that carries additional metadata for the PODetailsView class.
    [MetadataTypeAttribute(typeof(PODetailsView.PODetailsViewMetadata))]
    public partial class PODetailsView
    {

        // This class allows you to attach custom attributes to properties
        // of the PODetailsView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PODetailsViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PODetailsViewMetadata()
            {
            }

            public Nullable<double> ConvertedTotal { get; set; }

            public Nullable<double> ConvertedUnitPrice { get; set; }

            public string Currency { get; set; }

            public int PODetailsID { get; set; }

            public string POID { get; set; }

            public int ProductID { get; set; }

            public string ProductName { get; set; }

            public Nullable<decimal> qty { get; set; }

            public Nullable<decimal> Total { get; set; }

            public Nullable<decimal> UnitPrice { get; set; }

            public string Uom { get; set; }
        }
    }
}
