
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


    // The MetadataTypeAttribute identifies ContactMetadata as the class
    // that carries additional metadata for the Contact class.
    [MetadataTypeAttribute(typeof(Contact.ContactMetadata))]
    public partial class Contact
    {

        // This class allows you to attach custom attributes to properties
        // of the Contact class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ContactMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ContactMetadata()
            {
            }

            public string address { get; set; }

            public Nullable<bool> archive { get; set; }

            public string BusinessPhone { get; set; }

            public string city { get; set; }

            public string Company { get; set; }

            public int ContactID { get; set; }

            public string Country { get; set; }

            public string email { get; set; }

            public string fax { get; set; }

            [Required]
            public string FirstName { get; set; }

            public string homePhone { get; set; }

            public string jobTitle { get; set; }

            [Required]
            public string LastName { get; set; }

            public string MobilePhone { get; set; }

            public string Notes { get; set; }

            public EntityCollection<PondsProductionCycle> PondsProductionCycles { get; set; }

            public EntityCollection<ProductSalesOrder> ProductSalesOrders { get; set; }

            public string State { get; set; }

            public EntityCollection<Task> Tasks { get; set; }

            public string WebPage { get; set; }

            public string zip { get; set; }
        }
    }
}
