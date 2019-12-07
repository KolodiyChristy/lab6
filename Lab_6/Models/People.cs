using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace Lab_6.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string firstName { get; set; }
        [MinLength(2)]
        public string lastName { get; set; }
        //[ForeignKey("Flat")]
        public int flatId { get; set; }
        public virtual Flat Flat { get; set; }
    }
}