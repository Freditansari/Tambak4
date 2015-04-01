
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies SumProductRequiredViewMetadata as the class
    // that carries additional metadata for the SumProductRequiredView class.
    [MetadataTypeAttribute(typeof(SumProductRequiredView.SumProductRequiredViewMetadata))]
    public partial class SumProductRequiredView
    {

        // This class allows you to attach custom attributes to properties
        // of the SumProductRequiredView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SumProductRequiredViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SumProductRequiredViewMetadata()
            {
            }

            public Nullable<DateTime> DueDate { get; set; }

            public int ProductID { get; set; }

            public string ProductName { get; set; }

            public Nullable<decimal> totalRequired { get; set; }
        }
    }
}
