
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


    // The MetadataTypeAttribute identifies FacilityMetadata as the class
    // that carries additional metadata for the Facility class.
    [MetadataTypeAttribute(typeof(Facility.FacilityMetadata))]
    public partial class Facility
    {

        // This class allows you to attach custom attributes to properties
        // of the Facility class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class FacilityMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private FacilityMetadata()
            {
            }

            public string Address { get; set; }

            public string Address2 { get; set; }

            public string City { get; set; }

            public Company Company { get; set; }

            public Nullable<int> CompanyID { get; set; }

            public string ContactPerson { get; set; }

            public string Country { get; set; }

            public string Email { get; set; }

            public Nullable<DateTime> EntryDate { get; set; }

            public int FacilityId { get; set; }

            public string FacilityName { get; set; }

            public string PhoneNumber { get; set; }

            public EntityCollection<PurchaseOrder> PurchaseOrders { get; set; }

            public string State { get; set; }

            public string UserID { get; set; }

            public string ZipCode { get; set; }
        }
    }
}
