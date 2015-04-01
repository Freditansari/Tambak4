
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


    // The MetadataTypeAttribute identifies DeliveryLogMetadata as the class
    // that carries additional metadata for the DeliveryLog class.
    [MetadataTypeAttribute(typeof(DeliveryLog.DeliveryLogMetadata))]
    public partial class DeliveryLog
    {

        // This class allows you to attach custom attributes to properties
        // of the DeliveryLog class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class DeliveryLogMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private DeliveryLogMetadata()
            {
            }

            public EntityCollection<BatchHeader> BatchHeaders { get; set; }

            [Required]
            public string DeliveryBatch { get; set; }

            public Nullable<DateTime> DeliveryDate { get; set; }

            public string DeliveryLogID { get; set; }

            public string DeliveryNote { get; set; }

            public string Location { get; set; }

            public PODetail PODetail { get; set; }

            public int PODetailsID { get; set; }

            public Product Product { get; set; }

            public Nullable<int> ProductID { get; set; }

            public double qtyReceived { get; set; }

            public string UserID { get; set; }
        }
    }
}
