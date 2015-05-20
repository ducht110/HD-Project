using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDServices.Models
{
    public class Page
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [MaxLength(5)]
        public string Language { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public int Order { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? ModificationDate { get; set; }

        public bool Published { get; set; }

        public int? ContentID { get; set; }

        public virtual Content Content { get; set; }

        public int? ParentID { get; set; }

        public virtual Page Parent { get; set; }

        public virtual ICollection<Page> Children { get; set; }
    }
}
