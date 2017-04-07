using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TravelOn.Models
{
    public class Rate
    {
        [Key]
        public int ID { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}