
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies ResultNoteMetadata as the class
    // that carries additional metadata for the ResultNote class.
    [MetadataTypeAttribute(typeof(ResultNote.ResultNoteMetadata))]
    public partial class ResultNote
    {

        // This class allows you to attach custom attributes to properties
        // of the ResultNote class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ResultNoteMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ResultNoteMetadata()
            {
            }

            public Nullable<DateTime> entryDate { get; set; }

            public int resultID { get; set; }

            public string ResultNote1 { get; set; }

            public Task Task { get; set; }

            public Nullable<int> taskID { get; set; }

            public string UserId { get; set; }
        }
    }
}
