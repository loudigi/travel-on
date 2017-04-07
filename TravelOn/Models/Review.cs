using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TravelOn.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter a Title.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter a Publish Date.")]
        [DataType(DataType.Date)]
        public DateTime Published { get; set; }

        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        [DisplayName("Image Path")]
        public string ImagePath { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Rate")]
        public int RateID { get; set; }

        public virtual Rate Rate { get; set; }
    }
}