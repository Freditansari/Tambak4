
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CumulativeFeedViewMetadata as the class
    // that carries additional metadata for the CumulativeFeedView class.
    [MetadataTypeAttribute(typeof(CumulativeFeedView.CumulativeFeedViewMetadata))]
    public partial class CumulativeFeedView
    {

        // This class allows you to attach custom attributes to properties
        // of the CumulativeFeedView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CumulativeFeedViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CumulativeFeedViewMetadata()
            {
            }

            public Nullable<double> Cumulative_Feed { get; set; }

            public int ProductionCycleID { get; set; }
        }
    }
}
