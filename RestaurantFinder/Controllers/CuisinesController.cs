using Microsoft.AspNetCore.Mvc;
using RestaurantFinder.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RestaurantFinder.Controllers
{
    public class CuisinesController : Controller 
    {
        private readonly RestaurantFinderContext _db;

        public CuisinesController(RestaurantFinderContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Cuisine> model = _db.Cuisines.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cuisine cuisine)
        {
            _db.Cuisines.Add(cuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
            return View(thisCuisine);
        }

        public ActionResult Delete(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
            return View(thisCuisine);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cuisine thisCuisine = _db.Cuisines.FirstOrDefault(cuisine => cuisine.CuisineId == id);
            _db.Cuisines.Remove(thisCuisine);
            _db.SaveChanges();
            return RedirectToAction("Index");
 
        }

        // public ActionResult DeleteAll()
        // {
        //     List<Cuisine> model = _db.Cuisines.ToList();
        //     return View(model);
        // }

        // [HttpPost, ActionName("DeleteAll")]
        // public ActionResult DeleteAllConfirmed()
        // {
        //     foreach (var cuisine in RestaurantFinderContext.Cuisines)
        //     {
        //         RestaurantFinderContext.Cuisines.Remove(cuisine);
        //     }
        //     RestaurantFinderContext.SaveChanges();
            
        //     // List<Cuisine> model = _db.Cuisines.ToList();
        //     // _db.Cuisines.Remove(model);
        //     // _db.SaveChanges();
        //     return RedirectToAction("Index");
        // }

    }
}