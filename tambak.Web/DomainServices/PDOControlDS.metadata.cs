
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies PDOControlMetadata as the class
    // that carries additional metadata for the PDOControl class.
    [MetadataTypeAttribute(typeof(PDOControl.PDOControlMetadata))]
    public partial class PDOControl
    {

        // This class allows you to attach custom attributes to properties
        // of the PDOControl class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PDOControlMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PDOControlMetadata()
            {
            }

            public string AccountingNotes { get; set; }

            [Range(0.00, 999999999999999999.99, ErrorMessage = "Nothing less than 0")]
            public Nullable<float> BuyPrice { get; set; }

            public Nullable<DateTime> Date { get; set; }

            public int ID { get; set; }

            public string InventoryID { get; set; }

            public string InventoryName { get; set; }

            public Nullable<bool> isClosed { get; set; }

            public Nullable<bool> isOrdered { get; set; }

            public Nullable<bool> isPaid { get; set; }

            [Required]
            public string NoPDO { get; set; }

            [Range(0.00, 999999999999999999.99, ErrorMessage = "Nothing less than 0")]
            public Nullable<float> OrderedQuantity { get; set; }

            public string ReceivedNotes { get; set; }

            [Range(0.00,999999999999999999.99,ErrorMessage="Nothing less than 0")]
            public Nullable<float> ReceivedQuantity { get; set; }

            public string UOM { get; set; }
        }
    }
}
