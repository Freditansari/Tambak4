
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies MasterTaxMetadata as the class
    // that carries additional metadata for the MasterTax class.
    [MetadataTypeAttribute(typeof(MasterTax.MasterTaxMetadata))]
    public partial class MasterTax
    {

        // This class allows you to attach custom attributes to properties
        // of the MasterTax class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class MasterTaxMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private MasterTaxMetadata()
            {
            }

            public string TaxDescription { get; set; }

            public int TaxID { get; set; }

            public Nullable<decimal> TaxRate { get; set; }
        }
    }
}
