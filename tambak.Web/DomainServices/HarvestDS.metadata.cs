
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies HarvestMetadata as the class
    // that carries additional metadata for the Harvest class.
    [MetadataTypeAttribute(typeof(Harvest.HarvestMetadata))]
    public partial class Harvest
    {

        // This class allows you to attach custom attributes to properties
        // of the Harvest class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class HarvestMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private HarvestMetadata()
            {
            }

           // [Required]
            public Nullable<int> Age { get; set; }

            public Nullable<DateTime> HarvestDate { get; set; }

            public Nullable<double> HarvestedPopulation { get; set; }

            public int HarvestID { get; set; }

            public Nullable<bool> isFinalHarvest { get; set; }

            public Nullable<int> Month { get; set; }

            public Nullable<double> NumberOfFry { get; set; }

            public int PondID { get; set; }

            public Nullable<double> PopulationLeft { get; set; }

            public int ProductionCycleID { get; set; }

            [Required]
            [Range(10, 300)]
            public Nullable<double> Size { get; set; }

            [Required]
            [Range(0,999999999999)]
            public Nullable<double> Weight { get; set; }
        }
    }
}
