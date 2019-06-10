using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class ClientsController : Controller
    {

        ApplicationDbContext db;
        public ClientsController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Clients
        public ActionResult Index()
        {
            return View(db.Clients.ToList());
        }

        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {
           
            var CurrentId = User.Identity.GetUserId();
            Client client = db.Clients.Where(c => c.UserId == CurrentId).FirstOrDefault();
            if (id == null)
            {
                
                
            }
            
            if (client == null)
            {

                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            //Setupdaysofweek();
            ClientViewModel cvm = new ClientViewModel();

            List<string> daysofweek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            var items = daysofweek;
            if (items != null)
            {
                ViewBag.DaysOfWeek = items;
            }

            cvm.Client = new Client();
            cvm.DaysOfWeek = new DaysofWeek();

            return View(cvm);
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Client, DaysOfWeek")] ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                clientViewModel.Client.Collection_Day = clientViewModel.DaysOfWeek.Day;
                clientViewModel.Client.UserId = User.Identity.GetUserId();
                db.Clients.Add(clientViewModel.Client);
                db.SaveChanges();
                return RedirectToAction("Create", "Addresses", new { id = clientViewModel.Client.Id });
            }

            return View();
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
      {
            ClientViewModel clientViewModel = new ClientViewModel();
            clientViewModel.Client = db.Clients.Find(id);
            List<string> daysofweek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            var items = daysofweek;
            if (items != null)
            {
                ViewBag.DaysOfWeek = items;
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (clientViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clientViewModel);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Client, DaysOfWeek")] ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                clientViewModel.Client.Collection_Day = clientViewModel.DaysOfWeek.Day;
                db.Entry(clientViewModel.Client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details","Clients", new { id = clientViewModel.Client.Id });
            }
            return View(clientViewModel);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int? id)
        {
            Client client = db.Clients.Find(id);
            if (id == null)
            {
                var CurrentId = User.Identity.GetUserId();
                client = db.Clients.Where(c => c.UserId == CurrentId).FirstOrDefault();
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.Clients.Find(id);
            db.Clients.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public void Setupdaysofweek()
        {

        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
