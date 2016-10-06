using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Entitites
{
    public class Employee
    {
        public Employee()
        {
            this.Tasks = new HashSet<Task>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [Column(TypeName = "tinyint")]
        public Title Title { get; set; }

        [MaxLength(50)]
        [Index("IX_Username", IsUnique = true)]
        public string Username { get; set; }

        [MaxLength(50)]
        public string Password { get; set; }

        public bool NotWork { get; set; }

        // Navigation Property
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
