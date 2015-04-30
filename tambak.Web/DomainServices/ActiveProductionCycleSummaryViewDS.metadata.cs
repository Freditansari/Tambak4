
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ActiveProductionCycleSamplingLogSummaryMetadata as the class
    // that carries additional metadata for the ActiveProductionCycleSamplingLogSummary class.
    [MetadataTypeAttribute(typeof(ActiveProductionCycleSamplingLogSummary.ActiveProductionCycleSamplingLogSummaryMetadata))]
    public partial class ActiveProductionCycleSamplingLogSummary
    {

        // This class allows you to attach custom attributes to properties
        // of the ActiveProductionCycleSamplingLogSummary class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ActiveProductionCycleSamplingLogSummaryMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ActiveProductionCycleSamplingLogSummaryMetadata()
            {
            }

            public Nullable<double> AverageDailyGrowth { get; set; }

            public Nullable<double> Biomass { get; set; }

            public Nullable<double> CummulativeADG { get; set; }

            public Nullable<int> CummulativeFeed { get; set; }

            public Nullable<int> Current_Age { get; set; }

            public Nullable<decimal> DailyFeed { get; set; }

            public Nullable<double> FCR { get; set; }

            public Nullable<double> FeedConsumptions { get; set; }

            public Nullable<double> FeedingRate { get; set; }

            public string FeedType { get; set; }

            public Nullable<int> Last_Sampling_Age { get; set; }

            public Nullable<double> MBW { get; set; }

            public string PondDescription { get; set; }

            public int PondID { get; set; }

            public Nullable<double> Populations { get; set; }

            public int ProductionCycleID { get; set; }

            public Nullable<double> Size { get; set; }

            public Nullable<double> SurvivalRate { get; set; }

            public Nullable<decimal> weeklyfcr { get; set; }

            public Nullable<int> WeeklyFeed { get; set; }

            public Nullable<double> WeightPerWeek { get; set; }
        }
    }
}
