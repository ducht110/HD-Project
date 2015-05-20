using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.Models
{
    public class News: Content
    {
        [Key]
        [Required]
        public int ID { get; set; }

        public string HeadLine { get; set; }

        public string Image { get; set; }

        public string Thumbnail { get; set; }

        public string Introduction { get; set; }

        public string ImageAlt { get; set; }

        public string HomeIntroduction { get; set; }

        [Required]
        public int NewsCategoryID { get; set; }

        public virtual NewsCategory NewsCategory { get; set; }
    }
}
