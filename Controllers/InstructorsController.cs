﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jb213215_MIS4200.DAL;
using jb213215_MIS4200.Models;

namespace jb213215_MIS4200.Controllers
{
    public class InstructorsController : Controller
    {
        private Context db = new Context();

        // GET: Instructors
        public ActionResult Index()
        {
            return View(db.Instructors.ToList());
        }

        // GET: Instructors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructors instructors = db.Instructors.Find(id);
            if (instructors == null)
            {
                return HttpNotFound();
            }
            return View(instructors);
        }

        // GET: Instructors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instructors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "instructorID,firstName,lastName,email,startDate")] Instructors instructors)
        {
            if (ModelState.IsValid)
            {
                db.Instructors.Add(instructors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(instructors);
        }

        // GET: Instructors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructors instructors = db.Instructors.Find(id);
            if (instructors == null)
            {
                return HttpNotFound();
            }
            return View(instructors);
        }

        // POST: Instructors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "instructorID,firstName,lastName,email,startDate")] Instructors instructors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instructors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(instructors);
        }

        // GET: Instructors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instructors instructors = db.Instructors.Find(id);
            if (instructors == null)
            {
                return HttpNotFound();
            }
            return View(instructors);
        }

        // POST: Instructors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Instructors instructors = db.Instructors.Find(id);
            db.Instructors.Remove(instructors);
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
