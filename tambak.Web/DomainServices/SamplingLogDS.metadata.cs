
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies SamplingLogMetadata as the class
    // that carries additional metadata for the SamplingLog class.
    [MetadataTypeAttribute(typeof(SamplingLog.SamplingLogMetadata))]
    public partial class SamplingLog
    {

        // This class allows you to attach custom attributes to properties
        // of the SamplingLog class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SamplingLogMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SamplingLogMetadata()
            {
            }

            [Required]
            [Range(0,120, ErrorMessage = "Day of culture must be on range of 0 to 120")]
            public Nullable<int> Age { get; set; }

            [Required]
            public Nullable<double> AverageDailyGrowth { get; set; }

            [Required]
            public Nullable<double> Biomass { get; set; }

            [Required]
            public Nullable<double> CummulativeADG { get; set; }

            [Required]
            public Nullable<int> CummulativeFeed { get; set; }

            [Required]
            public Nullable<double> DailyFeed { get; set; }

            [Required]
            public Nullable<double> FCR { get; set; }

            [Required]
            public Nullable<double> FeedConsumptions { get; set; }

            [Required]
            public Nullable<double> feedingRate { get; set; }

            public string FeedType { get; set; }

            public Nullable<DateTime> LogDate { get; set; }

            public int LogID { get; set; }

            [Required]
            [Range(0,26, ErrorMessage= "Enter range from 0-26")]
            public Nullable<double> MedianBodyWeight { get; set; }

           
            public PondsProductionCycle PondsProductionCycle { get; set; }

            [Required]
            public Nullable<double> Populations { get; set; }

            [Required]
            public Nullable<int> ProductionCycleID { get; set; }

            [Required]
            public Nullable<double> Size { get; set; }

            [Required]
            public Nullable<double> SurvivalRate { get; set; }

           [Required]
            public string UserID { get; set; }

            [Required]
            public Nullable<decimal> WeeklyFCR { get; set; }

            [Required]
            public Nullable<int> WeeklyFeed { get; set; }

            [Required]
            public Nullable<double> WeightperWeek { get; set; }
        }
    }
}
