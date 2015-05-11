
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies FeedingTrayMetadata as the class
    // that carries additional metadata for the FeedingTray class.
    [MetadataTypeAttribute(typeof(FeedingTray.FeedingTrayMetadata))]
    public partial class FeedingTray
    {

        // This class allows you to attach custom attributes to properties
        // of the FeedingTray class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FeedingTrayMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FeedingTrayMetadata()
            {
            }

            public Nullable<double> C10 { get; set; }

            public Nullable<double> C14 { get; set; }

            public Nullable<double> C18 { get; set; }

            public Nullable<double> C6 { get; set; }

            public Nullable<DateTime> lastUpdate { get; set; }

            public Nullable<DateTime> LogDate { get; set; }

            public int logID { get; set; }

            public string note { get; set; }

            public PondsProductionCycle PondsProductionCycle { get; set; }

            public Nullable<int> ProductionCycleID { get; set; }

            public string userName { get; set; }
        }
    }
}
