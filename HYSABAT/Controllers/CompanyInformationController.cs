using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    public class CompanyInformationController : Controller
    {
        public readonly ApplicationDbContext _db;
        public CompanyInformationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<CompanyContactInformation> Index()
        {

            var contact = _db.companyContactInformation;
            return contact;
        }
        [HttpPost]
        public IActionResult CreateCompanyInfo(CompanyContactInformation model)
        {
            if (ModelState.IsValid)
            {
                if(_db.companyContactInformation.Count() <= 0)
                {
                    _db.companyContactInformation.Add(model);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else if(_db.companyContactInformation.Count() > 1)
                {
                    return BadRequest("Cannot Add");
                }
             
            }
            return View();
        }
        [HttpPost]
        public IActionResult UpdateComapnyInfo(CompanyContactInformation model)
        {
            if (ModelState.IsValid)
            {
                var companyInfo = _db.companyContactInformation.Find(model.Id);
                if(companyInfo != null)
                {
                    companyInfo.CompanyLocation = model.CompanyLocation;
                    companyInfo.CompanyName = model.CompanyName;
                    companyInfo.CompanyPhone = model.CompanyPhone;
                    companyInfo.Email = model.Email;
                    _db.companyContactInformation.Update(companyInfo);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound();
                }
            }
            return View();
        }
       
    }
}
