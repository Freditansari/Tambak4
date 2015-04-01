
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies FRGuideMetadata as the class
    // that carries additional metadata for the FRGuide class.
    [MetadataTypeAttribute(typeof(FRGuide.FRGuideMetadata))]
    public partial class FRGuide
    {

        // This class allows you to attach custom attributes to properties
        // of the FRGuide class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FRGuideMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FRGuideMetadata()
            {
            }

            public Nullable<decimal> FR { get; set; }

            public int ID { get; set; }

            public decimal MBW { get; set; }
        }
    }
}
