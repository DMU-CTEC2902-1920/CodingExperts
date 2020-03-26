using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameReviewSitePrototype.Data;
using GameReviewSitePrototype.Models;

namespace GameReviewSitePrototype.Controllers
{
    public class DevelopersController : Controller
    {
        //creates a new list of developers
        private readonly List<Developer> _developer = new List<Developer>()
        {
            //assign the record number
            new Developer {DeveloperID = 1,
            //adding name
            DeveloperName = "Activision",
            //adding description
            DeveloperDescription = "Experts in first shooter games, produced a lot of titles such as :" +
                "   Call Of Duty " },

            //assign the record number
            new Developer {DeveloperID = 2,
            //adding name
            DeveloperName = "EA",
            //adding description
            DeveloperDescription = "Produced a lot of sporting games, they released titles such as :" +
                "    Fifa 20 "},
            //assign the record number
            new Developer {DeveloperID = 3,
            //adding name
            DeveloperName = "Valve",
            //adding description
            DeveloperDescription = "Prouced a lot of fps shooter titles, their biggest titles include : " +
                "    Half-Life"}
        };
        
        private DeveloperContext db = new DeveloperContext();

        // GET: Developers
        public ActionResult Index()
        {
            //index page responsible of passing data to the presentation layer
            return View(_developer);
        }

        // GET: Developers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Developer selectedDeveloper = _developer.First(p => p.DeveloperID == id);
            if (selectedDeveloper == null)
            {
                return HttpNotFound();
            }
            return View(selectedDeveloper);
        }

        // GET: Developers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Developers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeveloperID,DeveloperName,DeveloperDescription")] Developer developer)
        {
            if (ModelState.IsValid)
            {
                db.Developers.Add(developer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(developer);
        }

        // GET: Developers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Developer developer = db.Developers.Find(id);
            if (developer == null)
            {
                return HttpNotFound();
            }
            ViewBag.GamesID = new SelectList(db.Games, "GameID", "GameName","GameActive",developer.DeveloperID);
            return View(developer);
        }

        // POST: Developers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeveloperID,DeveloperName,DeveloperDescription")] Developer developer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(developer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(developer);
        }

        // GET: Developers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Developer developer = db.Developers.Find(id);
            if (developer == null)
            {
                return HttpNotFound();
            }
            return View(developer);
        }

        // POST: Developers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Developer developer = db.Developers.Find(id);
            db.Developers.Remove(developer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
