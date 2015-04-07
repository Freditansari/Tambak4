
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


    // The MetadataTypeAttribute identifies TaskMetadata as the class
    // that carries additional metadata for the Task class.
    [MetadataTypeAttribute(typeof(Task.TaskMetadata))]
    public partial class Task
    {

        // This class allows you to attach custom attributes to properties
        // of the Task class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class TaskMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private TaskMetadata()
            {
            }

            [Required]
            public int assignedTo { get; set; }

            
            public string Attachments { get; set; }

            public Nullable<double> CompletePercentage { get; set; }

            public Contact Contact { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            public Nullable<DateTime> DueDate { get; set; }

            public Nullable<DateTime> EndDate { get; set; }

            public Nullable<bool> isDone { get; set; }

            public Nullable<double> plannedManHours { get; set; }

          
            public Pond Pond { get; set; }

            [Required]
            public Nullable<int> PondID { get; set; }

            public PondsProductionCycle PondsProductionCycle { get; set; }

            public string Priority { get; set; }

            [Required]
            public Nullable<int> ProductionCycleID { get; set; }

            public EntityCollection<ProductRequired> ProductRequireds { get; set; }

            public EntityCollection<ProductSalesOrder> ProductSalesOrders { get; set; }

            public string ReccurencePattern { get; set; }

            public EntityCollection<ResultNote> ResultNotes { get; set; }

            public Nullable<DateTime> StartDate { get; set; }

            [Required]
            public string Status { get; set; }

            public int TaskID { get; set; }

            [Required]
            public string Title { get; set; }

            public string UserId { get; set; }
        }
    }
}
