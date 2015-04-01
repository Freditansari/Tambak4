
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


    // The MetadataTypeAttribute identifies MasterCurrencyMetadata as the class
    // that carries additional metadata for the MasterCurrency class.
    [MetadataTypeAttribute(typeof(MasterCurrency.MasterCurrencyMetadata))]
    public partial class MasterCurrency
    {

        // This class allows you to attach custom attributes to properties
        // of the MasterCurrency class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class MasterCurrencyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private MasterCurrencyMetadata()
            {
            }

            public string CurrencyCulture { get; set; }

            public string CurrencyName { get; set; }

            public EntityCollection<CurrencyRate> CurrencyRates { get; set; }

            public string CurrencyShortName { get; set; }

            public Nullable<bool> isDefault { get; set; }

            public EntityCollection<PurchaseOrder> PurchaseOrders { get; set; }
        }
    }
}
