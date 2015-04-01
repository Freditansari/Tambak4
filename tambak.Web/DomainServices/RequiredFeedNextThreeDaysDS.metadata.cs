
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies RequiredFeedNext3daysMetadata as the class
    // that carries additional metadata for the RequiredFeedNext3days class.
    [MetadataTypeAttribute(typeof(RequiredFeedNext3days.RequiredFeedNext3daysMetadata))]
    public partial class RequiredFeedNext3days
    {

        // This class allows you to attach custom attributes to properties
        // of the RequiredFeedNext3days class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RequiredFeedNext3daysMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RequiredFeedNext3daysMetadata()
            {
            }

            public string NoPakan { get; set; }

            public Nullable<double> Pakan { get; set; }
        }
    }
}
