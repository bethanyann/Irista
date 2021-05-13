using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Irista.Data.Entities
{
    public class Photo : BaseEntity
    {
        public Photo()
        {

        }

        //Foreign Keys
        [ForeignKey("Location")]
        public string LocationId { get; set; }

        [ForeignKey("Metadata")]
        public string MetadataId { get; set; }

        //Strings
        [StringLength(128)]
        public string PhotoTitle { get; set; }

        [StringLength(500)]
        public string Caption { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; } //will be value 1-5

        [StringLength(128)]
        public string ImagePath { get; set; }  //this might become a navigation prop to Azure blob storage class

        [StringLength(128)]
        public string FileName { get; set; }

        [StringLength(30)]
        public string FileFormat { get; set; } //extension of photo (.jpg, .RAW, etc)

        public string ByteData { get; set; }

        public string FileSize { get; set; }  //something like 260.00KB

        public string Resolution { get; set; } //something like 1024x510

        //DateTime
        public DateTime? DatePhotoTakenUtc { get; set; }
        public DateTime? DateDeletedUtc { get; set; }
        public DateTime? DateLastModifiedUtc { get; set; }

        //Navigation Properties - eager loading
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Album> Albums { get; set; } //should one photo be able to be in many albums? 

        public virtual Location Location { get; set; }
        public virtual Metadata Metadata { get; set; }

        //the virtual keyword enables lazy loading and I don't think I want that right now. 
        // public virtual ICollection<Tag> Tags { get; set; }
    }
}
