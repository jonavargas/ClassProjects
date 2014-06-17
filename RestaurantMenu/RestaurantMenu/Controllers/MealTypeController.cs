﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantMenu.DataAccess;

namespace RestaurantMenu.Controllers
{
    public class MealTypeController : Controller
    {
        private RestaurantMenuEntities db = new RestaurantMenuEntities();

        //
        // GET: /MealType/

        public ActionResult Index()
        {
            return View(db.MealTypes.ToList());
        }

        //
        // GET: /MealType/Details/5

        public ActionResult Details(int id = 0)
        {
            MealType mealtype = db.MealTypes.Find(id);
            if (mealtype == null)
            {
                return HttpNotFound();
            }
            return View(mealtype);
        }

        //
        // GET: /MealType/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MealType/Create

        [HttpPost]
        public ActionResult Create(MealType mealtype)
        {
            if (ModelState.IsValid)
            {
                db.MealTypes.Add(mealtype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mealtype);
        }

        //
        // GET: /MealType/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MealType mealtype = db.MealTypes.Find(id);
            if (mealtype == null)
            {
                return HttpNotFound();
            }
            return View(mealtype);
        }

        //
        // POST: /MealType/Edit/5

        [HttpPost]
        public ActionResult Edit(MealType mealtype)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mealtype).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mealtype);
        }

        //
        // GET: /MealType/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MealType mealtype = db.MealTypes.Find(id);
            if (mealtype == null)
            {
                return HttpNotFound();
            }
            return View(mealtype);
        }

        //
        // POST: /MealType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MealType mealtype = db.MealTypes.Find(id);
            db.MealTypes.Remove(mealtype);
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