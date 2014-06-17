using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.DataAccess;

namespace RestaurantMenu.Controllers
{
    public class RestCategoryController : Controller
    {
        private RestaurantMenuEntities db = new RestaurantMenuEntities();

        //
        // GET: /RestCategory/

        public ActionResult Index()
        {
            return View(db.RestaurantCategories.ToList());
        }

        //
        // GET: /RestCategory/Details/5

        public ActionResult Details(int id = 0)
        {
            RestaurantCategory restaurantcategory = db.RestaurantCategories.Find(id);
            if (restaurantcategory == null)
            {
                return HttpNotFound();
            }
            return View(restaurantcategory);
        }

        //
        // GET: /RestCategory/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RestCategory/Create

        [HttpPost]
        public ActionResult Create(RestaurantCategory restaurantcategory)
        {
            if (ModelState.IsValid)
            {
                db.RestaurantCategories.Add(restaurantcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurantcategory);
        }

        //
        // GET: /RestCategory/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RestaurantCategory restaurantcategory = db.RestaurantCategories.Find(id);
            if (restaurantcategory == null)
            {
                return HttpNotFound();
            }
            return View(restaurantcategory);
        }

        //
        // POST: /RestCategory/Edit/5

        [HttpPost]
        public ActionResult Edit(RestaurantCategory restaurantcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurantcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurantcategory);
        }

        //
        // GET: /RestCategory/Delete/5

        public ActionResult Delete(int id = 0)
        {
            RestaurantCategory restaurantcategory = db.RestaurantCategories.Find(id);
            if (restaurantcategory == null)
            {
                return HttpNotFound();
            }
            return View(restaurantcategory);
        }

        //
        // POST: /RestCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RestaurantCategory restaurantcategory = db.RestaurantCategories.Find(id);
            db.RestaurantCategories.Remove(restaurantcategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}