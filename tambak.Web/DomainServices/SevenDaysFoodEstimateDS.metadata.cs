
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies RequredFeedNext7daysMetadata as the class
    // that carries additional metadata for the RequredFeedNext7days class.
    [MetadataTypeAttribute(typeof(RequredFeedNext7days.RequredFeedNext7daysMetadata))]
    public partial class RequredFeedNext7days
    {

        // This class allows you to attach custom attributes to properties
        // of the RequredFeedNext7days class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class RequredFeedNext7daysMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private RequredFeedNext7daysMetadata()
            {
            }

            public string NoPakan { get; set; }

            public Nullable<double> Pakan { get; set; }
        }
    }
}
