
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies WaterParameterRangeViewMetadata as the class
    // that carries additional metadata for the WaterParameterRangeView class.
    [MetadataTypeAttribute(typeof(WaterParameterRangeView.WaterParameterRangeViewMetadata))]
    public partial class WaterParameterRangeView
    {

        // This class allows you to attach custom attributes to properties
        // of the WaterParameterRangeView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class WaterParameterRangeViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private WaterParameterRangeViewMetadata()
            {
            }

            public Nullable<DateTime> LogDate { get; set; }

            public Nullable<double> MaxDO { get; set; }

            public Nullable<double> MaxPH { get; set; }

            public Nullable<double> MaxTemp { get; set; }

            public Nullable<double> MinDO { get; set; }

            public Nullable<double> MinPH { get; set; }

            public Nullable<double> MinTemp { get; set; }

            public int ProductionCycleID { get; set; }

            public Nullable<double> RangeDO { get; set; }

            public Nullable<double> RangePH { get; set; }

            public long RowID { get; set; }

            public Nullable<double> TemperatureRange { get; set; }

            public Nullable<double> TotalOrganicMaterial { get; set; }
        }
    }
}
