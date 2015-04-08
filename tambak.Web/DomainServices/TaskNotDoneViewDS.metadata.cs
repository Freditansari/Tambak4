
namespace tambak.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies TaskNotDoneViewMetadata as the class
    // that carries additional metadata for the TaskNotDoneView class.
    [MetadataTypeAttribute(typeof(TaskNotDoneView.TaskNotDoneViewMetadata))]
    public partial class TaskNotDoneView
    {

        // This class allows you to attach custom attributes to properties
        // of the TaskNotDoneView class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TaskNotDoneViewMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TaskNotDoneViewMetadata()
            {
            }

            public int assignedTo { get; set; }

            public string Attachments { get; set; }

            public Nullable<double> CompletePercentage { get; set; }

            public string Description { get; set; }

            public Nullable<DateTime> DueDate { get; set; }

            public Nullable<DateTime> EndDate { get; set; }

            public Nullable<bool> isDone { get; set; }

            public Nullable<double> plannedManHours { get; set; }

            public string PondDescription { get; set; }

            public string Priority { get; set; }

            public Nullable<int> ProductionCycleID { get; set; }

            public string ReccurencePattern { get; set; }

            public Nullable<DateTime> StartDate { get; set; }

            public string Status { get; set; }

            public int TaskID { get; set; }

            public string Title { get; set; }

            public string UserId { get; set; }
        }
    }
}
