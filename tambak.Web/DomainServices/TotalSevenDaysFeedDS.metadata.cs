
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies TotalSevenDaysFeedMetadata as the class
    // that carries additional metadata for the TotalSevenDaysFeed class.
    [MetadataTypeAttribute(typeof(TotalSevenDaysFeed.TotalSevenDaysFeedMetadata))]
    public partial class TotalSevenDaysFeed
    {

        // This class allows you to attach custom attributes to properties
        // of the TotalSevenDaysFeed class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TotalSevenDaysFeedMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TotalSevenDaysFeedMetadata()
            {
            }

            public Nullable<DateTime> Date { get; set; }

            public int ProductionCycleID { get; set; }

            public Nullable<double> TotalFeedGiven { get; set; }
        }
    }
}
