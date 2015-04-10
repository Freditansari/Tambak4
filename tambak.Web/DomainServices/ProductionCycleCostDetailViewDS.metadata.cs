
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ProductionCycleCostDetailViewMetadata as the class
    // that carries additional metadata for the ProductionCycleCostDetailView class.
    [MetadataTypeAttribute(typeof(ProductionCycleCostDetailView.ProductionCycleCostDetailViewMetadata))]
    public partial class ProductionCycleCostDetailView
    {

        // This class allows you to attach custom attributes to properties
        // of the ProductionCycleCostDetailView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ProductionCycleCostDetailViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ProductionCycleCostDetailViewMetadata()
            {
            }

            public int BatchTrxID { get; set; }

            public string CategoryName { get; set; }

            public Nullable<double> Cost { get; set; }

            public Nullable<int> ProductionCycleID { get; set; }

            public string ProductName { get; set; }

            public Nullable<DateTime> TrxDate { get; set; }
        }
    }
}
