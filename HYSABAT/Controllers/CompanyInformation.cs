using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    public class CompanyInformation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
