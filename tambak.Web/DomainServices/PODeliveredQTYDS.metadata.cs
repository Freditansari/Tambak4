
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PODeliveredQtyMetadata as the class
    // that carries additional metadata for the PODeliveredQty class.
    [MetadataTypeAttribute(typeof(PODeliveredQty.PODeliveredQtyMetadata))]
    public partial class PODeliveredQty
    {

        // This class allows you to attach custom attributes to properties
        // of the PODeliveredQty class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PODeliveredQtyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PODeliveredQtyMetadata()
            {
            }

            public Nullable<int> PODetailsID { get; set; }

            public string POID { get; set; }

            public Nullable<double> qtyReceived { get; set; }
        }
    }
}
