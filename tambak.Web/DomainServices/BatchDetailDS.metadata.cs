
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies BatchDetailMetadata as the class
    // that carries additional metadata for the BatchDetail class.
    [MetadataTypeAttribute(typeof(BatchDetail.BatchDetailMetadata))]
    public partial class BatchDetail
    {

        // This class allows you to attach custom attributes to properties
        // of the BatchDetail class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class BatchDetailMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private BatchDetailMetadata()
            {
            }

            public BatchHeader BatchHeader { get; set; }

            public int batchHeaderID { get; set; }

            public int BatchTrxID { get; set; }

            public double BuyPrice { get; set; }

            public bool isVoid { get; set; }

            public PondsProductionCycle PondsProductionCycle { get; set; }

            public Product Product { get; set; }

            public int ProductID { get; set; }

            public Nullable<int> ProductionCycleID { get; set; }

            public double Quantity { get; set; }

            public Nullable<int> SalesOrderDetailID { get; set; }

            public Nullable<double> soldPrice { get; set; }

            public Nullable<DateTime> TrxDate { get; set; }

            public string userName { get; set; }
        }
    }
}
