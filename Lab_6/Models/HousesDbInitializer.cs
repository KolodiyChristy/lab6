using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Lab_6.Models
{
    public class HousesDbInitializer : DropCreateDatabaseAlways<Lab6Context>
    {
        protected override void Seed(Lab6Context db)
        {
            db.Houses.Add(new House { houseId = 1, amountOfFlats = 30, Street = "Horodotska" });
            db.Houses.Add(new House { houseId = 2, amountOfFlats = 26, Street = "Stryiska" });
            db.Houses.Add(new House { houseId = 3, amountOfFlats = 35, Street = "Kulisha" });
            db.Houses.Add(new House { houseId = 4, amountOfFlats = 38, Street = "Naukova" });
            db.Flats.Add(new Flat { flatId = 1, Street = "Horodotska", houseId = 1 });
            db.Flats.Add(new Flat { flatId = 2, Street = "Stryiska", houseId = 2 });
            db.Flats.Add(new Flat { flatId = 3, Street = "Kulisha", houseId = 3 });
            db.Flats.Add(new Flat { flatId = 4, Street = "Naukova", houseId = 4 });
            db.People.Add(new People { firstName = "Christy", lastName = "Kolodiy", flatId = 1 });
            db.People.Add(new People { firstName = "Oksana", lastName = "Tomkiv", flatId = 2 });
            db.People.Add(new People { firstName = "Yaryna", lastName = "Novytska", flatId = 3 });
            db.People.Add(new People { firstName = "Sofia", lastName = "Nedilska", flatId = 4 });
            base.Seed(db);
        }
    }
}