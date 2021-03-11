using Microsoft.AspNetCore.Mvc;
using RestaurantFinder.Models;
using System.Collections.Generic;

namespace RestaurantFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}