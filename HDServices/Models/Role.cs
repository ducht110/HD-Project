using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public string Name { get; set; }

        [Required]
        public string Permission { get; set; }

        [Required]
        public bool IsGroup { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
