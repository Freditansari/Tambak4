
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CurrentInventoryViewMetadata as the class
    // that carries additional metadata for the CurrentInventoryView class.
    [MetadataTypeAttribute(typeof(CurrentInventoryView.CurrentInventoryViewMetadata))]
    public partial class CurrentInventoryView
    {

        // This class allows you to attach custom attributes to properties
        // of the CurrentInventoryView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CurrentInventoryViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CurrentInventoryViewMetadata()
            {
            }

            public string CategoryName { get; set; }

            public Nullable<double> Inventory_Level { get; set; }

            public Nullable<bool> IsFinishedProduct { get; set; }

            public int ProductID { get; set; }

            public string ProductName { get; set; }

            public string Uom { get; set; }
        }
    }
}
