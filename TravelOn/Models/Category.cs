using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelOn.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Category")]
        public string Name { get; set; }
    }
}