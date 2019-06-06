using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;


namespace TrashCollector.Controllers
{
    public class AddressesController : Controller
    {
        ApplicationDbContext db;
        public AddressesController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Addresses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Addresses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Addresses/Create
        public ActionResult Create(int id)
        {
            Address address = new Address();
            address.Clientuserid = id;
            return View(address);
        }

        // POST: Addresses/Create
        [HttpPost]
        public ActionResult Create(Address address)
        {
            try
            {
                // Address address = new Address();
                // address.Clientuserid = client.Id;
                
                db.Addresses.Add(address);
                db.SaveChanges();
                return RedirectToAction("Details","Clients");
            }
            catch
            {
                return View();
            }
        }

        // GET: Addresses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Addresses/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Addresses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Addresses/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
