
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies RequiredFeedNext10DaysMetadata as the class
    // that carries additional metadata for the RequiredFeedNext10Days class.
    [MetadataTypeAttribute(typeof(RequiredFeedNext10Days.RequiredFeedNext10DaysMetadata))]
    public partial class RequiredFeedNext10Days
    {

        // This class allows you to attach custom attributes to properties
        // of the RequiredFeedNext10Days class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RequiredFeedNext10DaysMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RequiredFeedNext10DaysMetadata()
            {
            }

            public string NoPakan { get; set; }

            public Nullable<double> Pakan { get; set; }
        }
    }
}
