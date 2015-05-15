using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.Models
{
    [Table("Teacher")]
    public class Teacher : Person
    {
        [StringLength(50)]
        [Required]
        public string TeacherCode { get; set; }

        public string ClassID { get; set; }
    }
}
