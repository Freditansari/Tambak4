
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies batchQuantityViewMetadata as the class
    // that carries additional metadata for the batchQuantityView class.
    [MetadataTypeAttribute(typeof(batchQuantityView.batchQuantityViewMetadata))]
    public partial class batchQuantityView
    {

        // This class allows you to attach custom attributes to properties
        // of the batchQuantityView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class batchQuantityViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private batchQuantityViewMetadata()
            {
            }

            public Nullable<DateTime> BatchDate { get; set; }

            public int BatchID { get; set; }

            public int ProductID { get; set; }

            public Nullable<double> Unit_Available { get; set; }

            public double unitCost { get; set; }
        }
    }
}
