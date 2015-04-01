
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


    // The MetadataTypeAttribute identifies BatchHeaderMetadata as the class
    // that carries additional metadata for the BatchHeader class.
    [MetadataTypeAttribute(typeof(BatchHeader.BatchHeaderMetadata))]
    public partial class BatchHeader
    {

        // This class allows you to attach custom attributes to properties
        // of the BatchHeader class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class BatchHeaderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private BatchHeaderMetadata()
            {
            }

            public Nullable<DateTime> BatchDate { get; set; }

            public EntityCollection<BatchDetail> BatchDetails { get; set; }

            public int BatchID { get; set; }

            public DeliveryLog DeliveryLog { get; set; }

            public string DeliveryLogID { get; set; }

            public Nullable<DateTime> ExpireDate { get; set; }

            public Nullable<int> FacilitiesID { get; set; }

            public Facility Facility { get; set; }

            public string Location { get; set; }

            public PODetail PODetail { get; set; }

            public Nullable<int> PODetailID { get; set; }

            public Product Product { get; set; }

            public int ProductID { get; set; }

            public double unitCost { get; set; }
        }
    }
}
