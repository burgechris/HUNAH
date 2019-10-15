using Microsoft.AspNetCore.Mvc;
using Hunah.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hunah.Controllers
{
    public class SpeciesController : Controller
    {
        private readonly HunahContext _db;

        public SpeciesController(HunahContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Species> model = _db.Species.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Species species)
        {
            _db.Species.Add(species);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Species thisSpecies = _db.Species.FirstOrDefault(species => species.SpeciesId == id);
            return View(thisSpecies);
        }

        public ActionResult Edit(int id)
        {
            var thisSpecies = _db.Species.FirstOrDefault(species => species.SpeciesId == id);
            return View(thisSpecies);
        }

        [HttpPost]
        public ActionResult Edit(Species species)
        {
            _db.Entry(species).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisSpecies = _db.Species.FirstOrDefault(species => species.SpeciesId == id);
            return View(thisSpecies);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisSpecies = _db.Species.FirstOrDefault(species => species.SpeciesId == id);
            _db.Species.Remove(thisSpecies);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}