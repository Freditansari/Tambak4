
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies FeedingLogMetadata as the class
    // that carries additional metadata for the FeedingLog class.
    [MetadataTypeAttribute(typeof(FeedingLog.FeedingLogMetadata))]
    public partial class FeedingLog
    {

        // This class allows you to attach custom attributes to properties
        // of the FeedingLog class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FeedingLogMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FeedingLogMetadata()
            {
            }

            public Nullable<double> CummulativeFeed { get; set; }

            [Required]
            [Range(0.00,10000.00,ErrorMessage="Enter Value between 0-10,000")]
            public Nullable<double> feedGiven { get; set; }

            public int FeedLogID { get; set; }

            public Nullable<double> feedPerDay { get; set; }

            public string feedType { get; set; }

            public Nullable<DateTime> LogDate { get; set; }

            
            public PondsProductionCycle PondsProductionCycle { get; set; }

            public Product Product { get; set; }

            [Required]
            //[RegularExpression("[0-9]")]
            public Nullable<int> ProductID { get; set; }

            [Required]
            public int ProductionCycleID { get; set; }

            public string UserID { get; set; }

            public Nullable<int> waterLevel { get; set; }
        }
    }
}
