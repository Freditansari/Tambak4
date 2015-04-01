
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


    // The MetadataTypeAttribute identifies CompanyMetadata as the class
    // that carries additional metadata for the Company class.
    [MetadataTypeAttribute(typeof(Company.CompanyMetadata))]
    public partial class Company
    {

        // This class allows you to attach custom attributes to properties
        // of the Company class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CompanyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CompanyMetadata()
            {
            }

            [Required]
            public string Address { get; set; }

            public string Address2 { get; set; }

            [Required]
            public string City { get; set; }

            public int CompanyID { get; set; }

            [Required]
            public string CompanyName { get; set; }

            [Required]
            public string ContactPerson { get; set; }

            [Required]
            public string Country { get; set; }

            [Required]
            public string Email { get; set; }

            public string EntryDate { get; set; }

            public EntityCollection<Facility> Facilities { get; set; }

            [Required]
            public string PhoneNumber { get; set; }

            public string UserID { get; set; }

            [Required]
            public string ZipCode { get; set; }
        }
    }
}
