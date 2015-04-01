
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CurrencyRateMetadata as the class
    // that carries additional metadata for the CurrencyRate class.
    [MetadataTypeAttribute(typeof(CurrencyRate.CurrencyRateMetadata))]
    public partial class CurrencyRate
    {

        // This class allows you to attach custom attributes to properties
        // of the CurrencyRate class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CurrencyRateMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CurrencyRateMetadata()
            {
            }

            public int CurrencyRateID { get; set; }

            public string CurrencyShortCode { get; set; }

            public MasterCurrency MasterCurrency { get; set; }

            public Nullable<double> MiddleRate { get; set; }

            public Nullable<double> PurchaseRate { get; set; }

            public Nullable<double> SellRate { get; set; }

            public Nullable<DateTime> TransactionDate { get; set; }
        }
    }
}
