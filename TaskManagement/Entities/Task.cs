using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Entitites
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [ForeignKey("Request")]
        public Nullable<int> RequestId { get; set; }

        public DateTime CreationDate { get; set; }

        public Nullable<DateTime> AssignmentDate { get; set; }

        public Nullable<float> EstimatedDuration { get; set; }

        public Nullable<DateTime> Deadline { get; set; }

        public Nullable<DateTime> CompletedDate { get; set; }        

        [ForeignKey("Project")]
        public Nullable<int> ProjectId { get; set; }

        [ForeignKey("Employee")]
        public Nullable<int> AssignedTo { get; set; }

        public bool IsPassive { get; set; }

        
        
        //Navigation Property
        public virtual Request Request { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
