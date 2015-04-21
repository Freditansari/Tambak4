
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies WaterParameterLogMetadata as the class
    // that carries additional metadata for the WaterParameterLog class.
    [MetadataTypeAttribute(typeof(WaterParameterLog.WaterParameterLogMetadata))]
    public partial class WaterParameterLog
    {

        // This class allows you to attach custom attributes to properties
        // of the WaterParameterLog class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class WaterParameterLogMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private WaterParameterLogMetadata()
            {
            }

            public Nullable<double> ammonium { get; set; }

            public Nullable<double> Amonnia { get; set; }

            public string Bacteria { get; set; }

            public Nullable<double> DissolvedOxygen { get; set; }

            public Nullable<bool> IMNV { get; set; }

            public Nullable<bool> isVibrioExist { get; set; }

            public Nullable<DateTime> LogDate { get; set; }

            public Nullable<double> nitrate { get; set; }

            public Nullable<double> nitrite { get; set; }

            public Nullable<int> Paddlewheel { get; set; }

            public Nullable<double> pH { get; set; }

            public Nullable<double> Phospate { get; set; }

            public Nullable<int> Planktons { get; set; }

            public PondsProductionCycle PondsProductionCycle { get; set; }

            public Nullable<double> PotentialRedox { get; set; }

            public int ProductionCycleID { get; set; }

            public Nullable<double> Salinity { get; set; }

            public Nullable<double> Temperature { get; set; }

            public string UserID { get; set; }

            public string Vibrio { get; set; }

            public int WaterLogID { get; set; }

            public Nullable<bool> WhiteSpot { get; set; }
        }
    }
}
