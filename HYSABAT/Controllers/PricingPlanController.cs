using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using HYSABAT.Models.PlanViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    public class PricingPlanController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public PricingPlanController(ApplicationDbContext db, IWebHostEnvironment web)
        {
            _db = db;
            _webHostEnvironment = web;
        }
        public IEnumerable<PricingPlan> Index()
        {
            var data = from x in _db.pricingPlans select x;
            return data;
           
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreatePricingPlan(PricingPlanVM model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                string extension = Path.GetExtension(model.FileImage.FileName);


                string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "PricingPlan");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.FileImage.CopyTo(stream);
                }
                model.ImageURL = uniqueFileName;

                var obj = new PricingPlan()
                {
                    PricingPlanTitle = model.Title,
                    PricingPlanMonthlyPrice = model.MonthlyPrice,
                    PricingPlanYearlyPrice = model.YearlyPrice,
                   planfeatures1 = model.planfeatures1,
                   planfeatures2 = model.planfeatures2,
                   planfeatures3 = model.planfeatures3,
                   planfeatures4 = model.planfeatures4,
                   planfeatures5 = model.planfeatures5,
                    PricingPlanImageURL = uniqueFileName
                };
                _db.pricingPlans.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
       
        public IActionResult DeletePricingPlan( PricingPlanVM model)
        {
            if (ModelState.IsValid)
            {
                var pricingplan = _db.pricingPlans.Find(model.Id);
                if(pricingplan == null)
                {
                    return NotFound();
                }

                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "PricingPlan",pricingplan.PricingPlanImageURL);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
                _db.pricingPlans.Remove(pricingplan);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        
        public IActionResult UpdatePricingPlan(PricingPlanVM model)
        {
            if (ModelState.IsValid)
            {
                var prices = _db.pricingPlans.Find(model.Id); 
             

                prices.PricingPlanTitle = model.Title;
                prices.PricingPlanMonthlyPrice = model.MonthlyPrice;
                prices.PricingPlanYearlyPrice = model.YearlyPrice;
                prices.planfeatures1 = model.planfeatures1;
                prices.planfeatures2 = model.planfeatures2;
                prices.planfeatures3 = model.planfeatures3;
                prices.planfeatures4 = model.planfeatures4;
                prices.planfeatures5 = model.planfeatures5;


                if (model.FileImage != null)
                {
                    if (prices.PricingPlanImageURL != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "PricingPlan", prices.PricingPlanImageURL);
                        System.IO.File.Delete(filePath);
                    }
                    prices.PricingPlanImageURL = PricingPlanUploadFile(model);
                }

                _db.pricingPlans.Update(prices);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        private string PricingPlanUploadFile(PricingPlanVM model)
        {
            string uniqueFileName = null;
            string extension = Path.GetExtension(model.FileImage.FileName);

            string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "PricingPlan");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
            string filePath = Path.Combine(uploadFolder, uniqueFileName);
            //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.FileImage.CopyTo(stream);
            }

            model.ImageURL = uniqueFileName;
            return uniqueFileName;
        }
        
    }

}
