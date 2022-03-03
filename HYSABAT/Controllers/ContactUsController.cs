using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
  
    public class ContactUsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContactUsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<ContactUs> Index()
        {
            IEnumerable<ContactUs> contacts = _db.contactUs.ToList();
            return contacts;
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateContact(ContactUs model)
        {
            if (ModelState.IsValid)
            {
               
               
                _db.contactUs.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
        
        public IActionResult UpdateContact(ContactUs model)
        {
            if (ModelState.IsValid)
            {
               
                var database = _db.contactUs.Find(model.Id);
             
                database.Country = model.Country;
                database.Email = model.Email;
                database.FullName = model.FullName;
                database.Subject = model.Subject;
                database.MobileNumber = model.MobileNumber;
                database.Message = model.Message;
               
                _db.contactUs.Update(database);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpPost]
      
        public IActionResult DeleteContact(ContactUs model)
        {
            
                var obj = _db.contactUs.Find(model.Id);
                if (obj == null)
                {
                    return NotFound();
                }
                _db.contactUs.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
           
       
        }
    }
}
