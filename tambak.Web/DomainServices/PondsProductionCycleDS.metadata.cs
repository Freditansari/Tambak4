
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PondsProductionCycleMetadata as the class
    // that carries additional metadata for the PondsProductionCycle class.
    [MetadataTypeAttribute(typeof(PondsProductionCycle.PondsProductionCycleMetadata))]
    public partial class PondsProductionCycle
    {

        // This class allows you to attach custom attributes to properties
        // of the PondsProductionCycle class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PondsProductionCycleMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PondsProductionCycleMetadata()
            {
            }

            public Contact Contact { get; set; }

            public Nullable<double> Density { get; set; }

            public Nullable<DateTime> EndDate { get; set; }

            public EntityCollection<FeedingLog> FeedingLogs { get; set; }

            public string FryOrigin { get; set; }

            public Nullable<bool> isInProduction { get; set; }

            public string Note { get; set; }

            public Nullable<int> NumberOfFry { get; set; }

            public EntityCollection<PondConsumptionsLog> PondConsumptionsLogs { get; set; }

            public int PondID { get; set; }

            public int ProductionCycleID { get; set; }

            public EntityCollection<SamplingLog> SamplingLogs { get; set; }

            //public Nullable<DateTime> StartDate { get; set; }
            public DateTime StartDate { get; set; }

            public EntityCollection<Task> Tasks { get; set; }

            public Nullable<int> Technician { get; set; }

            public EntityCollection<WaterParameterLog> WaterParameterLogs { get; set; }
        }
    }
}
