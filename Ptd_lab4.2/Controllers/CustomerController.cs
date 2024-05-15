using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ptd_lab4._2.Models; // Assuming this namespace contains your models and repository

namespace Ptd_lab4._2.Controllers
{
    public class CustomerController : Controller
    {
        // Declare a static variable for CustomerRepository
        static CustomerRepository listCustomer;

        // Initialize the CustomerRepository in the constructor
        static CustomerController()
        {
            listCustomer = new CustomerRepository();
        }

        // GET: /Customer/GetCustomers
        public ActionResult GetCustomers()
        {
            var customers = listCustomer.GetCustomers();
            return View(customers);
        }

        // POST: /Customer/GetCustomers
        [HttpPost]
        public ActionResult GetCustomers(string name)
        {
            var customers = listCustomer.SearchCustomer(name);
            return View(customers);
        }

        // GET: /Customer/Details/5
        public ActionResult Details(string id)
        {
            var customer = listCustomer.GetCustomer(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PtdCustomer cus)
        {
            if (ModelState.IsValid)
            {
                listCustomer.AddCustomer(cus);
                return RedirectToAction("GetCustomers");
            }
            return View(cus);
        }

        // GET: /Customer/Edit/5
        public ActionResult Edit(string id)
        {
            var customer = listCustomer.GetCustomer(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: /Customer/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PtdCustomer cus)
        {
            if (ModelState.IsValid)
            {
                listCustomer.UpdateCustomer(cus);
                return RedirectToAction("GetCustomers");
            }
            return View(cus);
        }

        // GET: /Customer/Delete/5
        public ActionResult Delete(string id)
        {
            var customer = listCustomer.GetCustomer(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: /Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var customer = listCustomer.GetCustomer(id);
            if (customer != null)
            {
                listCustomer.DeleteCustomer(customer);
            }
            return RedirectToAction("GetCustomers");
        }
    }
}