using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab_6.Models
{
   
        public class Lab6Context : DbContext
        {
            public Lab6Context() : base("name=Lab6") { }
            public DbSet<House> Houses { get; set; }
            public DbSet<Flat> Flats { get; set; }
            public DbSet<People> People { get; set; }
        }
    }
