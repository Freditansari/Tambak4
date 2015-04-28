
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies FeedingAuditViewMetadata as the class
    // that carries additional metadata for the FeedingAuditView class.
    [MetadataTypeAttribute(typeof(FeedingAuditView.FeedingAuditViewMetadata))]
    public partial class FeedingAuditView
    {

        // This class allows you to attach custom attributes to properties
        // of the FeedingAuditView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FeedingAuditViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FeedingAuditViewMetadata()
            {
            }

            public Nullable<int> DayOfCulture { get; set; }

            public int FeedingHistoryID { get; set; }

            public Nullable<double> FeedingPlan { get; set; }

            public int ProductionCycleID { get; set; }

            public Nullable<double> Total_Feed { get; set; }
        }
    }
}
