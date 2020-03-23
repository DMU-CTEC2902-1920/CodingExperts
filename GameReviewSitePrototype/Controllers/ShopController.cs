using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameReviewSitePrototype.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ViewResult Index()
        {
            ViewBag.Title = "The Shop";
            ViewBag.WelcomeMessage = "Welcome to the games shop. Kindly spend all your money with us!!";
            ViewData["CurrentTime"] = DateTime.Now;
            return View(); 
        }

        public string Product(int id)
        {
            return "Product: Id = " + id.ToString();
        }

        public RedirectResult GameCD()
        {
            return Redirect("~/Shop/Product");
        }
    }
}