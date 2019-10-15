using Microsoft.AspNetCore.Mvc;
using Hunah.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            List<Animal> model = _db.Animals.OrderBy(animals => animals.Name).ToList();
            return View(model);
        }
        // this actionResult "OrderBy" lists the DB entries by alphabetical order

        //[HttpGet]
        public ActionResult Edit(int id)
        {
            var thisAnimal = _db.Animals.FirstOrDefault(animals => animals.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost]
        public ActionResult Edit(Animal animal)
        {
            _db.Entry(animal).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisAnimal = _db.Animals.FirstOrDefault(items => items.AnimalId == id);
            return View(thisAnimal);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisItem = _db.Animals.FirstOrDefault(items => items.AnimalId == id);
            _db.Animals.Remove(thisItem);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // [HttpGet]
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