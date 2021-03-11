using Microsoft.AspNetCore.Mvc;
using RestaurantFinder.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RestaurantFinder.Controllers
{
    public class RestaurantsController : Controller 
    {
        private readonly RestaurantFinderContext _db;

        public RestaurantsController(RestaurantFinderContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurant => restaurant.RestaurantId == id);
            return View(thisRestaurant);
        }
    }
}
