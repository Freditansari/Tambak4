
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CurrentActivePondMetadata as the class
    // that carries additional metadata for the CurrentActivePond class.
    [MetadataTypeAttribute(typeof(CurrentActivePond.CurrentActivePondMetadata))]
    public partial class CurrentActivePond
    {

        // This class allows you to attach custom attributes to properties
        // of the CurrentActivePond class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CurrentActivePondMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CurrentActivePondMetadata()
            {
            }

            public Nullable<int> DOC { get; set; }

            public Nullable<int> NumberOfFry { get; set; }

            public string PondDescription { get; set; }

            public int PondID { get; set; }

            public int ProductionCycleID { get; set; }
        }
    }
}
