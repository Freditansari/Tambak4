
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PondConsumptionsLogMetadata as the class
    // that carries additional metadata for the PondConsumptionsLog class.
    [MetadataTypeAttribute(typeof(PondConsumptionsLog.PondConsumptionsLogMetadata))]
    public partial class PondConsumptionsLog
    {

        // This class allows you to attach custom attributes to properties
        // of the PondConsumptionsLog class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PondConsumptionsLogMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PondConsumptionsLogMetadata()
            {
            }

            public Nullable<int> BatchDetailID { get; set; }

            public Nullable<int> BatchHeaderID { get; set; }

            public Nullable<double> BuyPrice { get; set; }

            public string ConsumptionsBatchID { get; set; }

            public Nullable<DateTime> LogDate { get; set; }

            public int LogID { get; set; }

            public string Note { get; set; }

            public Pond Pond { get; set; }

            public Nullable<int> PondID { get; set; }

            public PondsProductionCycle PondsProductionCycle { get; set; }

            public Product Product { get; set; }

            public Nullable<int> ProductGroupID { get; set; }

            public int ProductID { get; set; }

            public Nullable<int> ProductionCycleID { get; set; }

            public double Qty { get; set; }

            public string UOM { get; set; }

            public string userId { get; set; }
        }
    }
}
