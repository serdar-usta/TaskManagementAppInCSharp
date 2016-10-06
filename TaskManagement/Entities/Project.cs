using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Entitites
{
    public class Project
    {
        public Project()
        {
            this.Requests = new HashSet<Request>();
            this.Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        [Index("IX_ProjectName", IsUnique = true)]
        public string Name { get; set; }

        [MaxLength(8000), Column(TypeName = "varchar")]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompletedDate { get; set; }

        public bool IsPassive { get; set; }

        // Navigation Property
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
