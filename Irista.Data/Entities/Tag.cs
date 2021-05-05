using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Irista.Data.Entities
{
    public class Tag : BaseEntity
    {
        [Required]
        [StringLength(30)]
        public string TagName { get; set; }

        public DateTime? DateDeletedUtc { get; set; }
        public DateTime? DateLastModifiedUtc { get; set; }

        //Many to many relationship with Photos
        public ICollection<Photo> Photos { get; set; }

        //the virtual keyword enables lazy loading and I don't think I want that right now. 
        //public virtual ICollection<Photo> Photos { get; set; }
    }
}
