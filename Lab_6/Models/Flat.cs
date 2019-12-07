using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace Lab_6.Models
{
    public class Flat
    {
        [Key]
        public int flatId { get; set; }
        [Required]
        // public int houseId { get; set; }
        //[ForeignKey("House")]
        public string Street { get; set; }
        public int houseId { get; set; }
        public virtual List<People> People { get; set; }

        public virtual House House { get; set; }
    }
}