
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CalendarMetadata as the class
    // that carries additional metadata for the Calendar class.
    [MetadataTypeAttribute(typeof(Calendar.CalendarMetadata))]
    public partial class Calendar
    {

        // This class allows you to attach custom attributes to properties
        // of the Calendar class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CalendarMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CalendarMetadata()
            {
            }

            public Nullable<byte> D { get; set; }

            public string dayname { get; set; }

            public DateTime dt { get; set; }

            public Nullable<byte> DW { get; set; }

            public Nullable<short> FY { get; set; }

            public Nullable<bool> isHoliday { get; set; }

            public Nullable<bool> isWeekday { get; set; }

            public Nullable<byte> M { get; set; }

            public string monthname { get; set; }

            public Nullable<byte> Q { get; set; }

            public Nullable<byte> UTCOffset { get; set; }

            public Nullable<byte> W { get; set; }

            public Nullable<short> Y { get; set; }
        }
    }
}
