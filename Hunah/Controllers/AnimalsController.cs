using Microsoft.AspNetCore.Mvc;
using Hunah.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hunah.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly HunahContext _db;

        public AnimalsController(HunahContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Animal> model = _db.Animals.ToList();
            return View(model);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Animal thisAnimal = _db.Animals.FirstOrDefault(animal => animal.AnimalId == id);
            //^This is our way of communicating to the database, giving it the id that was passed in and telling the database to give us the item in the database that has this id. In this line, "items" is not a special name.
            return View(thisAnimal);
        }
    }
}