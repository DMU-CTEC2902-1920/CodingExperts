using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameReviewSitePrototype.Models;

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

        public ViewResult Games()
        {
            GamesModel gamesModel = new GamesModel();
            gamesModel.GameName = "GTA V";
            gamesModel.GameDescription = "Very good game";
            gamesModel.Price = 350.00M;

            return View(gamesModel);
        }
        public RedirectResult GameCD()
        {
            return Redirect("~/Shop/Product");
        }
    }
}