using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_6.Models;

namespace Lab_6.Controllers
{
    public class HomeController : Controller
    {

        Lab6Context db = new Lab6Context();

        public ActionResult Index()
        {

            IEnumerable<People> people = db.People;
            ViewBag.People = people;
            return View();
        }
        [HttpGet]
        public ActionResult AddPeople(int id = 0)
        {
            //ViewBag.MovieId = id;
            return View();
        }
        [HttpPost]
        public void AddPeople(People people)
        {
            db.People.Add(people);
            db.SaveChanges();
            Response.Redirect("/Home");
        }
        [HttpGet]
        public ActionResult EditPeople(int id = 0)
        {
            ViewBag.PeopleId = id;
            People people = db.People
                .Where(o => o.Id == id)
                .FirstOrDefault();

            ViewBag.PeoplefirstName = people.firstName;
            ViewBag.PeoplelastName = people.lastName;
            ViewBag.PeopleflatId = people.flatId;
            return View();
        }
        [HttpPost]
        public void EditPeople(People people)
        {
            People people_update = db.People
                .Where(o => o.Id == people.Id)
                .FirstOrDefault();

            people_update.firstName = people.firstName;
            people_update.lastName = people.lastName;
            people_update.flatId = people.flatId;

            db.SaveChanges();
            Response.Redirect("/Home");
        }
    }
}