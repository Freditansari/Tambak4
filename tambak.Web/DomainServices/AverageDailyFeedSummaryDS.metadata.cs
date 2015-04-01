
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies AverageDailyFeedSummaryMetadata as the class
    // that carries additional metadata for the AverageDailyFeedSummary class.
    [MetadataTypeAttribute(typeof(AverageDailyFeedSummary.AverageDailyFeedSummaryMetadata))]
    public partial class AverageDailyFeedSummary
    {

        // This class allows you to attach custom attributes to properties
        // of the AverageDailyFeedSummary class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class AverageDailyFeedSummaryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private AverageDailyFeedSummaryMetadata()
            {
            }

            public Nullable<float> Average { get; set; }

            public int ProductionCycleID { get; set; }
        }
    }
}
