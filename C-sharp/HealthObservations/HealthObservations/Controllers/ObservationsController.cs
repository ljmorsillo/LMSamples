using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HealthObservations.Models;

namespace HealthObservations.Controllers
{
    public class ObservationsController : Controller
    {
        private PatientsDBContext db = new PatientsDBContext();

        //
        // GET: /Observations/

        public ActionResult Index()
        {
            return View(db.Measurements.ToList());
        }

        //
        // GET: /Observations/Details/5

        public ActionResult Details(int id = 0)
        {
            Measurement measurement = db.Measurements.Find(id);
            if (measurement == null)
            {
                return HttpNotFound();
            }
            return View(measurement);
        }

        //
        // GET: /Observations/Create

        public ActionResult Create(int id = 0)
        {
            //create list of patients and associated ID's
            //TODO There are better ways to do this...
            List<Patient> pats = new List<Patient>();
            foreach (Patient p in db.Patients)
            {
                pats.Add(p);
            }
            ViewData["patients"] = pats;
            return View();
        }

        //
        // POST: /Observations/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Measurement measurement)
        {
            if (ModelState.IsValid)
            {
                db.Measurements.Add(measurement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(measurement);
        }

        //
        // GET: /Observations/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Measurement measurement = db.Measurements.Find(id);
            if (measurement == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientList = new SelectList(db.Patients, "Id", "Lastname");
            return View(measurement);
        }

        //
        // POST: /Observations/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Measurement measurement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(measurement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(measurement);
        }

        //
        // GET: /Observations/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Measurement measurement = db.Measurements.Find(id);
            if (measurement == null)
            {
                return HttpNotFound();
            }
            return View(measurement);
        }

        //
        // POST: /Observations/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Measurement measurement = db.Measurements.Find(id);
            db.Measurements.Remove(measurement);
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