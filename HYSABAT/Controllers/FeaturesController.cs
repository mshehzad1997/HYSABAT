using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using HYSABAT.Models.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    //[Route("")]
    //[Route("Features")]
    //[Route("Features/Index")]
    //[Route("Features/Index/{id?}")]
    public class FeaturesController : Controller
    
    {
     
        private readonly ApplicationDbContext _db;

        private readonly IWebHostEnvironment _hostEnvironment;

        public FeaturesController(ApplicationDbContext db, IWebHostEnvironment hostnvironment)
        {
            _db = db;
            _hostEnvironment = hostnvironment;
        }
        //public Features FeatureIndex(int id)
        //{
        //    Features fe = _db.features.Find(id);
        //    return fe;
        //    //var data = from e in _db.features where e.DashboradTypes == "BI" select e;
        //    //var data = _db.features.Where(e => e.DashboradTypes == "BI").ToList();
        //    //return _db.features.ToList();
        //}  
           public IActionResult FeatureIndex()
        {
           
            return View();
            //var data = _db.features.Where(x => x.DashboradTypes == "BI").ToList();
            //return data;
            
        }
        public IActionResult CreateFutures()
        {
            return View();
        }
       
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult CreateFeatures(DashBoardFeatures model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                string extension = Path.GetExtension(model.ImageFile.FileName);
                string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "Features");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(stream);
                    model.ImageURL = uniqueFileName;
                }

                var featureModel = new Features()
                {
                    FeatureTitle = model.Title,
                    FeatureDescription = model.Description,
                    FeatureImagePath = uniqueFileName,
                    Id = model.Id,
                    DashboradTypes = (model.dashBoardType).ToString()
                };
                _db.features.Add(featureModel);
                _db.SaveChanges();
                return RedirectToAction("FeatureIndex");
            }
            return View();
        }
        //public IActionResult DeleteSalesInformation(int id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var saleInfo = _db.salesInformation.Find(id);
        //    if (saleInfo == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(saleInfo);
        //}

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteFeatures( DashBoardFeatures model)
        {
            if (ModelState.IsValid)
            {
                var features = _db.features.Find(model.Id);


                var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "Features", features.FeatureImagePath);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
                _db.features.Remove(features);
                _db.SaveChanges();
                return RedirectToAction("FeatureIndex");
            }
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult UpdateFeatures( DashBoardFeatures model)
        {
            if (ModelState.IsValid)
            {
                var features = _db.features.Find(model.Id);
                features.FeatureTitle = model.Title;
                features.FeatureDescription = model.Description;
                features.DashboradTypes =(model.dashBoardType).ToString();
              
                if (model.ImageFile != null)
                {
                    if (features.FeatureImagePath != null)
                    {
                        string filePath = Path.Combine(_hostEnvironment.WebRootPath, "Features",features.FeatureImagePath);
                        System.IO.File.Delete(filePath);
                    }
                    features.FeatureImagePath = FeatureUploadFile(model);
                }

                _db.features.Update(features);
                
                _db.SaveChanges();
                return RedirectToAction("FeatureIndex");
            }
            return View();
        }
        private string FeatureUploadFile(DashBoardFeatures model)
        {
            string uniqueFileName = null;
          

            string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "Features");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
            string filePath = Path.Combine(uploadFolder, uniqueFileName);
            //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }

           
            return uniqueFileName;
        }
        //public IActionResult AccountList(AccountManagement management)
        //{
        //    var allaccounts = _db.accountManagement.Select(c => new AccountManagement()
        //    {
        //        Title = c.AccountTitle,
        //        Description = c.AccountDescription,
        //        ImagePath = c.AccountImagePath
        //    });
        //    return View(allaccounts);
        //}
        //public IActionResult AccountCreate()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AccountCreate(AccountManagement account_management)
        //{

        //    //string fileName = Path.GetFileNameWithoutExtension(account.ImageFile.FileName);
        //    //string extension = Path.GetExtension(account.ImageFile.FileName);
        //    //fileName = fileName + extension;
        //    //account.ImagePath = "~/wwwroot/images" + fileName;
        //    //fileName = Path.Combine(IObserver.MapPath)
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
        //        string extension = Path.GetExtension(account_management.ImageFile.FileName);

        //        if (account_management.ImageFile != null)
        //        {

        //            string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
        //            uniqueFileName = Guid.NewGuid().ToString() + "_" + account_management.ImageFile.FileName;
        //            string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //            //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                account_management.ImageFile.CopyTo(stream);
        //            }

        //            account_management.ImagePath = uniqueFileName;

        //        }
               
        //        var accountmodel = new Account()
        //        {
        //            AccountTitle = account_management.Title,
        //            AccountDescription = account_management.Description,
        //            AccountImagePath = uniqueFileName,
        //            Id = account_management.Id,
                     
        //        };
        //        _db.accountManagement.Add(accountmodel);
        //        _db.SaveChanges();
        //        return RedirectToAction("AccountList");
        //    }
        //    return View();
        //}
        ////public IActionResult UpdateAccount(int? id)
        ////{
        ////    if(id == null || id == 0)
        ////    {
        ////        return NotFound();
        ////    }
        ////    var data = _db.accountManagement.Find(id);
        ////    var obj = new AccountManagement()
        ////    {
        ////        Title = data.AccountTitle,
        ////        Description = data.AccountDescription,
        ////        Id = data.Id

        ////    };
        ////    if(obj == null)
        ////    {
        ////        return NotFound();
        ////    }
        ////    return View(obj);
        ////}
        ////[HttpPost]
        ////[ValidateAntiForgeryToken]
        ////public IActionResult UpdateAccountPost()
        ////{

        ////}
        ////public IActionResult DeleteAccount(int? id)
        ////{
        //// if(id == null)
        ////    {
        ////        return NotFound();
        ////    }
        ////    var data = _db.accountManagement.FirstOrDefault(m => m.Id == id);
        ////    var management = new AccountManagement()
        ////    {
        ////        Id = data.Id,
        ////        Title = data.AccountTitle,
        ////        Description = data.AccountDescription,
        ////        ImagePath = data.AccountImagePath
        ////    };
        ////    if(management == null)
        ////    {
        ////        return NotFound();
        ////    }
        ////    return View(management);
        ////}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteAccountConfirm(int? id,  AccountManagement model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = _db.accountManagement.Find(id);


        //        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images", model.ImageFile.FileName);
        //        if (System.IO.File.Exists(imagePath))
        //            System.IO.File.Delete(imagePath);
        //        _db.accountManagement.Remove(database);
        //        _db.SaveChanges();
        //        return RedirectToAction("AccountList");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdateAccount(AccountManagement model)
        //{
        //    if (ModelState.IsValid)
        //    {
               
        //        var account = new Account();

        //        account.AccountTitle = model.Title;
        //        account.AccountDescription = model.Description;
        //        if (model.ImageFile != null)
        //        {
        //            if (model.ImagePath != null)
        //            {
        //                string filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", model.ImagePath);
        //                System.IO.File.Delete(filePath);
        //            }
        //            account.AccountImagePath = ProcessUploadFile(model);
        //        }

        //        _db.accountManagement.Add(account);
        //        _db.SaveChanges();
        //        return RedirectToAction("AccountList");
        //    }
        //    return View();
        //}

        //private string ProcessUploadFile(AccountManagement model)
        //{
        //    string uniqueFileName = null;
        //    string extension = Path.GetExtension(model.ImageFile.FileName);

        //    string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
        //    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
        //    string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //    //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        model.ImageFile.CopyTo(stream);
        //    }

        //    model.ImagePath = uniqueFileName;
        //    return uniqueFileName;
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult EmployeeList()
        //{
        //    var allemployee = _db.employees.Select(x => new EmployeeManagement()
        //    {
        //        Title = x.EmployeeTitle,
        //        Description = x.EmployeeDescription,
        //        ImageURL = x.EmployeeImageURL
        //    }).ToList();
        //    return View(allemployee);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult EmployeeCreate(EmployeeManagement employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
        //        string extension = Path.GetExtension(employee.ImageFile.FileName);


        //        string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "employeeImages");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.ImageFile.FileName;
        //        string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //        //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            employee.ImageFile.CopyTo(stream);
        //        }
        //        employee.ImageURL = uniqueFileName;
               
        //        var employeemodel = new Employee()
        //        {
        //            EmployeeTitle = employee.Title,
        //            EmployeeDescription = employee.Description,
        //            EmployeeImageURL = uniqueFileName,
        //            Id = employee.Id,
            
        //        };
        //        _db.employees.Add(employeemodel);
        //        _db.SaveChanges();
        //        return RedirectToAction("EmployeeList");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteEmploye(int? id,  EmployeeManagement model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = _db.employees.Find(id);


        //        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "employeeImages", model.ImageFile.FileName);
        //        if (System.IO.File.Exists(imagePath))
        //            System.IO.File.Delete(imagePath);
        //        _db.employees.Remove(database);
        //        _db.SaveChanges();
        //        return RedirectToAction("EmployeeList");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdateEmployee(EmployeeManagement model)
        //{

        //    if (ModelState.IsValid)
        //    {
                
        //        var emp = new Employee();

        //        emp.EmployeeTitle = model.Title;
        //        emp.EmployeeDescription = model.Description;
        //        if (model.ImageFile != null)
        //        {
        //            if (model.ImageURL != null)
        //            {
        //                string filePath = Path.Combine(_hostEnvironment.WebRootPath, "employeeImages", model.ImageURL);
        //                System.IO.File.Delete(filePath);
        //            }
        //            emp.EmployeeImageURL = EmployeeUploadFile(model);
        //        }

        //        _db.employees.Add(emp);
        //        _db.SaveChanges();
        //        return RedirectToAction("EmployeeList");
        //    }
        //    return View();
        //}
        //private string EmployeeUploadFile(EmployeeManagement model)
        //{
        //    string uniqueFileName = null;
        //    string extension = Path.GetExtension(model.ImageFile.FileName);

        //    string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "employeeImages");
        //    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
        //    string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //    //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        model.ImageFile.CopyTo(stream);
        //    }

        //    model.ImageURL = uniqueFileName;
        //    return uniqueFileName;
        //}
        //public IActionResult ListPurchaseHistory()
        //{
        //    var allpurchase = _db.purchases.Select(x => new PurchaseHistory()
        //    {
        //        Title = x.PurchaseTitle,
        //        Description = x.PurchaseDescription,
        //        ImageURL = x.PurchaseImageURL
        //    }).ToList();
        //    return View(allpurchase);

        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult PurchaseCreate(PurchaseHistory history)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
        //        string extension = Path.GetExtension(history.FileImage.FileName);


        //        string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "PurchaseHistory");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + history.FileImage.FileName;
        //        string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //        //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            history.FileImage.CopyTo(stream);
        //        }
        //        history.ImageURL = uniqueFileName;
              
        //        var historymodel = new Purchase()
        //        {
        //            PurchaseTitle = history.Title,
        //            PurchaseDescription = history.Description,
        //            PurchaseImageURL = uniqueFileName,
        //            PurchaseId = history.Id,
                     
        //        };
        //        _db.purchases.Add(historymodel);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeletePurchaseHistory( int? id,PurchaseHistory model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = _db.purchases.Find(id);


        //        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "PurchaseHistory", model.FileImage.FileName);
        //        if (System.IO.File.Exists(imagePath))
        //            System.IO.File.Delete(imagePath);
        //        _db.purchases.Remove(database);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdatePurchaseHistory(PurchaseHistory model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = _db.purchases.Find(model.Id);
        //        var purchaseModel = new Purchase();

        //        purchaseModel.PurchaseTitle = model.Title;
        //        purchaseModel.PurchaseDescription = model.Description;
        //        if (model.FileImage != null)
        //        {
        //            if (model.ImageURL != null)
        //            {
        //                string filePath = Path.Combine(_hostEnvironment.WebRootPath, "PurchaseHistory", model.ImageURL);
        //                System.IO.File.Delete(filePath);
        //            }
        //            purchaseModel.PurchaseImageURL = PurchaseUploadFile(model);
        //        }

        //        _db.purchases.Add(purchaseModel);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //private string PurchaseUploadFile(PurchaseHistory model)
        //{
        //    string uniqueFileName = null;
        //    string extension = Path.GetExtension(model.FileImage.FileName);

        //    string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "employeeImages");
        //    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
        //    string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //    //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        model.FileImage.CopyTo(stream);
        //    }

        //    model.ImageURL = uniqueFileName;
        //    return uniqueFileName;
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AssetList()
        //{
        //    var allassets = _db.assests.Select(x => new AssetManagement()
        //    {
        //        Title = x.AssetTitle,
        //        Description = x.AssestDescription,
        //        ImageURL = x.AssesImageURL
        //    }).ToList();
        //    return View(allassets);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AssetCreate(AssetManagement model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
               


        //        string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "Assets");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
        //        string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //        //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            model.FileImage.CopyTo(stream);
        //        }
        //        model.ImageURL = uniqueFileName;
               

        //        var assetmodel = new Assest()
        //        {
        //            AssetTitle = model.Title,
        //            AssestDescription = model.Description,
        //            AssesImageURL = uniqueFileName,
                   


        //        };
        //        _db.assests.Add(assetmodel);
        //        _db.SaveChanges();
        //        return RedirectToAction("AssetList");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteAsset(int? id,  AssetManagement model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = _db.assests.Find(id);


        //        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "Assets", model.FileImage.FileName);
        //        if (System.IO.File.Exists(imagePath))
        //            System.IO.File.Delete(imagePath);
        //        _db.assests.Remove(database);
        //        _db.SaveChanges();
        //        return RedirectToAction("AssetList");
        //    }
        //    return View();
        //}
        //public IActionResult UpdateAsset(AssetManagement model)
        //{
        //    if (ModelState.IsValid)
        //    {
              
        //        var assetModel = new Assest();

        //        assetModel.AssetTitle = model.Title;
        //        assetModel.AssestDescription = model.Description;
        //        if (model.FileImage != null)
        //        {
        //            if (model.ImageURL != null)
        //            {
        //                string filePath = Path.Combine(_hostEnvironment.WebRootPath, "Asset", model.ImageURL);
        //                System.IO.File.Delete(filePath);
        //            }
        //            assetModel.AssesImageURL = AssetUploadFile(model);
        //        }

        //        _db.assests.Add(assetModel);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}
        //private string AssetUploadFile(AssetManagement model)
        //{
        //    string uniqueFileName = null;
        //    string extension = Path.GetExtension(model.FileImage.FileName);

        //    string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "Assets");
        //    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
        //    string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //    //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        model.FileImage.CopyTo(stream);
        //    }

        //    model.ImageURL = uniqueFileName;
        //    return uniqueFileName;
        //}
       
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult ListHelpCenter()
        //{
        //    var allhelpcenter = _db.helps.Select(x => new HelpCenter()
        //    {
        //        Title = x.HelpCenterTitle,
        //        Description = x.HelpCenterDescription,
        //        ImageURL = x.HelpCenterImageURL
        //    }).ToList();
        //    return View(allhelpcenter);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult CreateHelpCenter(HelpCenter model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
        //        string extension = Path.GetExtension(model.FileImage.FileName);


        //        string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "HelpCenter");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
        //        string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //        //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            model.FileImage.CopyTo(stream);
        //        }
        //        model.ImageURL = uniqueFileName;
               

        //        var helpmodel = new Help()
        //        {
        //            HelpCenterTitle = model.Title,
        //            HelpCenterDescription = model.Description,
        //            HelpCenterImageURL = uniqueFileName,
                   

        //        };
        //        _db.helps.Add(helpmodel);
        //        _db.SaveChanges();
        //        return RedirectToAction("ListHelpCenter");
        //    }
        //    return View();
        //}
        //[HttpPost]
        ////[ValidateAntiForgeryToken]
        //public IActionResult DeleteHelpCenter(int? id, HelpCenter model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var database = _db.helps.Find(id);


        //        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "HelpCenter", model.FileImage.FileName);
        //        if (System.IO.File.Exists(imagePath))
        //            System.IO.File.Delete(imagePath);
        //        _db.helps.Remove(database);
        //        _db.SaveChanges();
        //        return RedirectToAction("ListHelpCenter");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult UpdateHelpCenter(HelpCenter model)
        //{
        //    if (ModelState.IsValid)
        //    {
               
        //        var helpcenterModel = new Help();

        //        helpcenterModel.HelpCenterTitle = model.Title;
        //        helpcenterModel.HelpCenterDescription = model.Description;
        //        if (model.FileImage != null)
        //        {
        //            if (model.ImageURL != null)
        //            {
        //                string filePath = Path.Combine(_hostEnvironment.WebRootPath, "HelpCenter", model.ImageURL);
        //                System.IO.File.Delete(filePath);
        //            }
        //            helpcenterModel.HelpCenterImageURL = HelpUploadFile(model);
        //        }

        //        _db.helps.Add(helpcenterModel);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");

        //    }
        //    return View();
        //}
        //private string HelpUploadFile(HelpCenter model)
        //{
        //    string uniqueFileName = null;
        //    string extension = Path.GetExtension(model.FileImage.FileName);

        //    string uploadFolder = Path.Combine(_hostEnvironment.WebRootPath, "HelpCenter");
        //    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileImage.FileName;
        //    string filePath = Path.Combine(uploadFolder, uniqueFileName);
        //    //account_management.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        model.FileImage.CopyTo(stream);
        //    }

        //    model.ImageURL = uniqueFileName;
        //    return uniqueFileName;
        //}
    }
}
