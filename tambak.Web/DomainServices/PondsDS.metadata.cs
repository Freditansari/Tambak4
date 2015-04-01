
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


    // The MetadataTypeAttribute identifies PondMetadata as the class
    // that carries additional metadata for the Pond class.
    [MetadataTypeAttribute(typeof(Pond.PondMetadata))]
    public partial class Pond
    {

        // This class allows you to attach custom attributes to properties
        // of the Pond class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PondMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PondMetadata()
            {
            }

            public EntityCollection<PondConsumptionsLog> PondConsumptionsLogs { get; set; }

            public string PondDescription { get; set; }

            public int PondID { get; set; }

            public string PondLocation { get; set; }

            public Nullable<int> pondSize { get; set; }

            public string pondUOM { get; set; }

            public EntityCollection<Task> Tasks { get; set; }
        }
    }
}
