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
    public class RestController : Controller
    {
        private RestaurantMenuEntities db = new RestaurantMenuEntities();

        //
        // GET: /Rest/

        public ActionResult Index()
        {
            var restaurants = db.Restaurants.Include(r => r.RestaurantCategory);
            return View(restaurants.ToList());
        }

        //
        // GET: /Rest/Details/5

        public ActionResult Details(int id = 0)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        //
        // GET: /Rest/Create

        public ActionResult Create()
        {
            ViewBag.RestaurantCategoryId = new SelectList(db.RestaurantCategories, "Id", "Name");
            return View();
        }

        //
        // POST: /Rest/Create

        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Restaurants.Add(restaurant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RestaurantCategoryId = new SelectList(db.RestaurantCategories, "Id", "Name", restaurant.RestaurantCategoryId);
            return View(restaurant);
        }

        //
        // GET: /Rest/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            ViewBag.RestaurantCategoryId = new SelectList(db.RestaurantCategories, "Id", "Name", restaurant.RestaurantCategoryId);
            return View(restaurant);
        }

        //
        // POST: /Rest/Edit/5

        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RestaurantCategoryId = new SelectList(db.RestaurantCategories, "Id", "Name", restaurant.RestaurantCategoryId);
            return View(restaurant);
        }

        //
        // GET: /Rest/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            if (restaurant == null)
            {
                return HttpNotFound();
            }
            return View(restaurant);
        }

        //
        // POST: /Rest/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurant restaurant = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurant);
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