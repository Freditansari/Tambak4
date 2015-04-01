
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PODeliveredQuantityMetadata as the class
    // that carries additional metadata for the PODeliveredQuantity class.
    [MetadataTypeAttribute(typeof(PODeliveredQuantity.PODeliveredQuantityMetadata))]
    public partial class PODeliveredQuantity
    {

        // This class allows you to attach custom attributes to properties
        // of the PODeliveredQuantity class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PODeliveredQuantityMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PODeliveredQuantityMetadata()
            {
            }

            public int PODetailsID { get; set; }

            public string POID { get; set; }

            public double qtyReceived { get; set; }
        }
    }
}
