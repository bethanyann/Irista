using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Irista.Data.Entities
{
    public class Album : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime? DateOfAlbum { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
