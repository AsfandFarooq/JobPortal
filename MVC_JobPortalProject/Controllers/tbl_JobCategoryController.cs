using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_JobPortalProject.Models;

namespace MVC_JobPortalProject.Controllers
{
    public class tbl_JobCategoryController : Controller
    {

        DB_Context db = new DB_Context();
        // GET: tbl_JobCategory
        public ActionResult Index()
        {
            return View(db.tbl_JobCategory.ToList());
        }

        // GET: tbl_JobCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_JobCategory tbl_JobCategory = db.tbl_JobCategory.Find(id);
            if (tbl_JobCategory == null)
            {
                return HttpNotFound();
            }
            return View(tbl_JobCategory);
        }

        // GET: tbl_JobCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_JobCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CID,CategoryName,CategoryStatus")] tbl_JobCategory tbl_JobCategory)
        {
            if (ModelState.IsValid)
            {
                db.tbl_JobCategory.Add(tbl_JobCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_JobCategory);
        }

        // GET: tbl_JobCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_JobCategory tbl_JobCategory = db.tbl_JobCategory.Find(id);
            if (tbl_JobCategory == null)
            {
                return HttpNotFound();
            }
            return View(tbl_JobCategory);
        }

        // POST: tbl_JobCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CID,CategoryName,CategoryStatus")] tbl_JobCategory tbl_JobCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_JobCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_JobCategory);
        }

        // GET: tbl_JobCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_JobCategory tbl_JobCategory = db.tbl_JobCategory.Find(id);
            if (tbl_JobCategory == null)
            {
                return HttpNotFound();
            }
            return View(tbl_JobCategory);
        }

        // POST: tbl_JobCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_JobCategory tbl_JobCategory = db.tbl_JobCategory.Find(id);
            db.tbl_JobCategory.Remove(tbl_JobCategory);
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
