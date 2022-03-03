using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using HYSABAT.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    public class ContactInformationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ContactInformationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<ContactInformation> Index()
        {
            var data = _db.contactInformation.Where(x => x.plans == ContactInformation.Plans.Monthly && x.Id == 4).ToList();
            return data;
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateContactInfo(ContactInformation model)
        {

            if (ModelState.IsValid)
            {

                _db.contactInformation.Add(model);
               
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
       
       
        [HttpPost]
       
        public IActionResult DeleteContactInfo(ContactInformation model)
        {
            var contactInfo = _db.contactInformation.Find(model.Id);
            if(contactInfo == null)
            {
                return NotFound();
            }
            _db.contactInformation.Remove(contactInfo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        
        public IActionResult UpdateContactInfo(ContactInformation model)
        {
            if (ModelState.IsValid)
            {

                var contactInfo = _db.contactInformation.Find(model.Id);
                contactInfo.FirstName = model.FirstName;
                contactInfo.LastName = model.LastName;
                contactInfo.Email = model.Email;
                contactInfo.NumberOfBranches = model.NumberOfBranches;
                contactInfo.NumberOfCustomer = model.NumberOfCustomer;
                contactInfo.NumberOfSupliers = model.NumberOfSupliers;
                contactInfo.NumberOfUser = model.NumberOfUser;
                contactInfo.Postal_ZipCode = model.Postal_ZipCode;
                contactInfo.Postion = model.Postion;
                contactInfo.Company = model.Company;
                contactInfo.City = model.City;
                contactInfo.CRNumber = model.CRNumber;
                contactInfo.PricingPlanId = model.PricingPlanId;
                contactInfo.State = model.State;
                contactInfo.ExpiryDate = model.ExpiryDate;
                contactInfo.CVC = model.CVC;
                contactInfo.CreditCardNumber = model.CreditCardNumber;
                contactInfo.Country = model.Country;
                contactInfo.AutoRenew = model.AutoRenew;
               
                _db.contactInformation.Update(contactInfo);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
