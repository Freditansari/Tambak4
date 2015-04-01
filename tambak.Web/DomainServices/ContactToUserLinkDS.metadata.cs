
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ContactToUserLinkMetadata as the class
    // that carries additional metadata for the ContactToUserLink class.
    [MetadataTypeAttribute(typeof(ContactToUserLink.ContactToUserLinkMetadata))]
    public partial class ContactToUserLink
    {

        // This class allows you to attach custom attributes to properties
        // of the ContactToUserLink class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ContactToUserLinkMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ContactToUserLinkMetadata()
            {
            }

            public Contact Contact { get; set; }

            public int ContactID { get; set; }

            public string Username { get; set; }
        }
    }
}
