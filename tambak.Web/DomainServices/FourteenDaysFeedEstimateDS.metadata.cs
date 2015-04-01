
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies RequiredFeedNext14daysMetadata as the class
    // that carries additional metadata for the RequiredFeedNext14days class.
    [MetadataTypeAttribute(typeof(RequiredFeedNext14days.RequiredFeedNext14daysMetadata))]
    public partial class RequiredFeedNext14days
    {

        // This class allows you to attach custom attributes to properties
        // of the RequiredFeedNext14days class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RequiredFeedNext14daysMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RequiredFeedNext14daysMetadata()
            {
            }

            public string NoPakan { get; set; }

            public Nullable<double> Pakan { get; set; }
        }
    }
}
