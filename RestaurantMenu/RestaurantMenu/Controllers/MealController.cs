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
    public class MealController : Controller
    {
        private RestaurantMenuEntities db = new RestaurantMenuEntities();

        //
        // GET: /Meal/

        public ActionResult Index()
        {
            var meals = db.Meals.Include(m => m.MealType).Include(m => m.Restaurant);
            return View(meals.ToList());
        }

        //
        // GET: /Meal/Details/5

        public ActionResult Details(int id = 0)
        {
            Meal meal = db.Meals.Find(id);
            if (meal == null)
            {
                return HttpNotFound();
            }
            return View(meal);
        }

        //
        // GET: /Meal/Create

        public ActionResult Create()
        {
            ViewBag.MealTypeId = new SelectList(db.MealTypes, "Id", "Name");
            ViewBag.RestaurantId = new SelectList(db.Restaurants, "Id", "Name");
            return View();
        }

        //
        // POST: /Meal/Create

        [HttpPost]
        public ActionResult Create(Meal meal)
        {
            if (ModelState.IsValid)
            {
                db.Meals.Add(meal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MealTypeId = new SelectList(db.MealTypes, "Id", "Name", meal.MealTypeId);
            ViewBag.RestaurantId = new SelectList(db.Restaurants, "Id", "Name", meal.RestaurantId);
            return View(meal);
        }

        //
        // GET: /Meal/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Meal meal = db.Meals.Find(id);
            if (meal == null)
            {
                return HttpNotFound();
            }
            ViewBag.MealTypeId = new SelectList(db.MealTypes, "Id", "Name", meal.MealTypeId);
            ViewBag.RestaurantId = new SelectList(db.Restaurants, "Id", "Name", meal.RestaurantId);
            return View(meal);
        }

        //
        // POST: /Meal/Edit/5

        [HttpPost]
        public ActionResult Edit(Meal meal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MealTypeId = new SelectList(db.MealTypes, "Id", "Name", meal.MealTypeId);
            ViewBag.RestaurantId = new SelectList(db.Restaurants, "Id", "Name", meal.RestaurantId);
            return View(meal);
        }

        //
        // GET: /Meal/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Meal meal = db.Meals.Find(id);
            if (meal == null)
            {
                return HttpNotFound();
            }
            return View(meal);
        }

        //
        // POST: /Meal/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Meal meal = db.Meals.Find(id);
            db.Meals.Remove(meal);
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