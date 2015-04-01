
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


    // The MetadataTypeAttribute identifies PurchaseOrderMetadata as the class
    // that carries additional metadata for the PurchaseOrder class.
    [MetadataTypeAttribute(typeof(PurchaseOrder.PurchaseOrderMetadata))]
    public partial class PurchaseOrder
    {

        // This class allows you to attach custom attributes to properties
        // of the PurchaseOrder class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class PurchaseOrderMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private PurchaseOrderMetadata()
            {
            }

            public Nullable<double> CurrencyRate { get; set; }

            public string CurrencyShortCode { get; set; }

            public Nullable<decimal> Discount { get; set; }

            public Nullable<DateTime> DueDate { get; set; }

            public Facility Facility { get; set; }

            public Nullable<bool> isComplete { get; set; }

            public string Note { get; set; }

            public Nullable<decimal> OtherFee { get; set; }

            public Nullable<DateTime> PoDate { get; set; }

            public EntityCollection<PODetail> PODetails { get; set; }

            public string POID { get; set; }

            public string POReference { get; set; }

            public Nullable<decimal> Shipping { get; set; }

            public int ShipTo { get; set; }

            public string Status { get; set; }

            public Nullable<decimal> SubTotal { get; set; }

            public Supplier Supplier { get; set; }

            public Nullable<decimal> taxRate { get; set; }

            public Nullable<decimal> TotalPrice { get; set; }

            public string UserName { get; set; }

            public int VendorID { get; set; }
        }
    }
}
