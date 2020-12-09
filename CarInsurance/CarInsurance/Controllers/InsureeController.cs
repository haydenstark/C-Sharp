using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Quote
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (insuree.FirstName == "" || insuree.LastName == "" || insuree.EmailAddress == "" || insuree.DateOfBirth == null || insuree.CarMake == "" || insuree.CarModel == "")
            {
                return Redirect("~/Views/Shared/Error.cshtml");
            }
            else
            {
                decimal quote = 50;

                int age = DateTime.Today.Year - insuree.DateOfBirth.Year;
                if (age < 19)
                {
                    quote += 100;
                }
                else if (age >= 19 && age < 25)
                {
                    quote += 50;
                }
                else
                {
                    quote += 25;
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    quote += 25;
                }

                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    quote += 50;
                }
                else if (insuree.CarMake == "Porsche")
                {
                    quote += 25;
                }

                if (insuree.SpeedingTickets > 0)
                {
                    int ticketTotal = insuree.SpeedingTickets * 10;
                    quote += ticketTotal;
                }

                if (insuree.DUI)
                {
                    quote *= 1.25m;
                }

                if (insuree.CoverageType)
                {
                    quote *= 1.5m;
                }

                insuree.Quote = quote;

                if (ModelState.IsValid)
                {
                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                    return Redirect("Index");
                }
                else
                {
                    return Redirect("~/Views/Shared/Error.cshtml");
                }
            }
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var Insurees = db.Insurees;
                var InsureeVMs = new List<InsureeVM>();
                foreach (var insuree in Insurees)
                {
                    var insureeVM = new InsureeVM();
                    insureeVM.FirstName = insuree.FirstName;
                    insureeVM.LastName = insuree.LastName;
                    insureeVM.EmailAddress = insuree.EmailAddress;
                    insureeVM.Quote = insuree.Quote;
                    InsureeVMs.Add(insureeVM);
                }
                return View(InsureeVMs);
            }
        }
    }
}
