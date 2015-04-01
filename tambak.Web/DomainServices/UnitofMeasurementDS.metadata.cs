
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies UnitofMeasurementMetadata as the class
    // that carries additional metadata for the UnitofMeasurement class.
    [MetadataTypeAttribute(typeof(UnitofMeasurement.UnitofMeasurementMetadata))]
    public partial class UnitofMeasurement
    {

        // This class allows you to attach custom attributes to properties
        // of the UnitofMeasurement class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class UnitofMeasurementMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private UnitofMeasurementMetadata()
            {
            }

            public int UOMID { get; set; }

            [Required]
            public string UOMName { get; set; }
        }
    }
}
