using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.Models
{
    public class NewsCategory: Content
    {
        [Key]
        [Required]
        public int ID { get; set; }
       
        [Required]
        public int Order { get; set; }

        public virtual ICollection<News> NewsList { get; set; }
    }
}
