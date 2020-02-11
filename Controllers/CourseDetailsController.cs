using System;
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
    public class CourseDetailsController : Controller
    {
        private Context db = new Context();

        // GET: CourseDetails
        public ActionResult Index()
        {
            return View(db.CourseDetails.ToList());
        }

        // GET: CourseDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetails courseDetails = db.CourseDetails.Find(id);
            if (courseDetails == null)
            {
                return HttpNotFound();
            }
            return View(courseDetails);
        }

        // GET: CourseDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "detailID,courseName,courseDescription,courseStartDate,instructorName")] CourseDetails courseDetails)
        {
            if (ModelState.IsValid)
            {
                db.CourseDetails.Add(courseDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseDetails);
        }

        // GET: CourseDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetails courseDetails = db.CourseDetails.Find(id);
            if (courseDetails == null)
            {
                return HttpNotFound();
            }
            return View(courseDetails);
        }

        // POST: CourseDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "detailID,courseName,courseDescription,instructorName")] CourseDetails courseDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseDetails);
        }

        // GET: CourseDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetails courseDetails = db.CourseDetails.Find(id);
            if (courseDetails == null)
            {
                return HttpNotFound();
            }
            return View(courseDetails);
        }

        // POST: CourseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseDetails courseDetails = db.CourseDetails.Find(id);
            db.CourseDetails.Remove(courseDetails);
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
