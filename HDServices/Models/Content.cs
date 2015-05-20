using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.Models
{
    public class Content
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [MaxLength(5)]
        [Required]
        public string Language { get; set; }

        [Required]
        public int Author { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        public string MetaKeyWords { get; set; }

        public string MetaTitle { get; set; }
        
        public string MetaDecription { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public DateTime? PublishDate { get; set; }

        public string XML { get; set; }

        [Required]
        public int Status { get; set; }

        public int? OriginID { get; set; }

        public bool IsNotified { get; set; }

        [MaxLength(255)]
        public string Slug { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
    }
}
