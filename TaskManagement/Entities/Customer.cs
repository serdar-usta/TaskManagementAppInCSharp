using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Entitites
{
    public class Customer
    {
        public Customer()
        {
            this.Requests = new HashSet<Request>();
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
                return string.IsNullOrEmpty(Company) ? string.Format("{0} {1}", FirstName, LastName) : string.Format("{0} {1} - ({2})", FirstName, LastName, Company);
            }
        }

        [MaxLength(100)]
        public string Company { get; set; }

        // Navigation Property
        public virtual ICollection<Request> Requests { get; set; }
    }
}
