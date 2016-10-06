using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Entitites
{
    public class Request
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [ForeignKey("Customer")]
        public int Owner { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        public DateTime RequestDate { get; set; }
        public RequestType RequestType { get; set; }
        public bool IsPassive { get; set; }

        //Navigation Property
        public virtual Customer Customer { get; set; }
        public virtual Project Project { get; set; }

    }
}
