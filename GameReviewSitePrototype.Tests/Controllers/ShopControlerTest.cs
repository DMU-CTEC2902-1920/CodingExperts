using System;
using System.Web.Mvc;
using GameReviewSitePrototype.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameReviewSitePrototype.Tests.Controllers
{
    [TestClass]
    public class ShopControlerTest
    {
        [TestMethod]
        public void IndexWelcomeMessage()
        {

            ShopController controller = new ShopController();
            ViewResult result = controller.Index();
            Assert.AreEqual("Welcome to the games shop. Kindly spend all your money with us!!", controller.ViewBag.WelcomeMessage);
        }
    }
}
