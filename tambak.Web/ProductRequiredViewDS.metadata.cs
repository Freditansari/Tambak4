
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ProductRequiredViewMetadata as the class
    // that carries additional metadata for the ProductRequiredView class.
    [MetadataTypeAttribute(typeof(ProductRequiredView.ProductRequiredViewMetadata))]
    public partial class ProductRequiredView
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductRequiredView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductRequiredViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductRequiredViewMetadata()
            {
            }

            public Nullable<decimal> Amount { get; set; }

            public Nullable<DateTime> DueDate { get; set; }

            public string PondDescription { get; set; }

            public int PondID { get; set; }

            public int ProductID { get; set; }

            public int ProductionCycleID { get; set; }

            public string ProductName { get; set; }

            public int TaskID { get; set; }

            public string Uom { get; set; }
        }
    }
}
