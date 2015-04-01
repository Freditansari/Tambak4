
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


    // The MetadataTypeAttribute identifies SupplierMetadata as the class
    // that carries additional metadata for the Supplier class.
    [MetadataTypeAttribute(typeof(Supplier.SupplierMetadata))]
    public partial class Supplier
    {

        // This class allows you to attach custom attributes to properties
        // of the Supplier class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SupplierMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SupplierMetadata()
            {
            }

            public string Address { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            [Required]
            public string CompanyName { get; set; }

            public string Country { get; set; }

            public string DOB { get; set; }

            public string Email { get; set; }

            public Nullable<DateTime> EntryDate { get; set; }

            [Required]
            public string FirstName { get; set; }

            [Required]
            public string LastName { get; set; }

            public string PhoneNumber { get; set; }

            public EntityCollection<PurchaseOrder> PurchaseOrders { get; set; }

            public int SupplierID { get; set; }

            public string UserID { get; set; }

            public string ZipCode { get; set; }
        }
    }
}
