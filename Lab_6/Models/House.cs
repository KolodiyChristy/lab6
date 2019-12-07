using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_6.Models
{
    public class House
    {
        [Key]
        public int houseId { get; set; }
        [Required]
        public int amountOfFlats { get; set; }
        public string Street { get; set; }

        public virtual List<Flat> Flats { get; set; }
    }
}