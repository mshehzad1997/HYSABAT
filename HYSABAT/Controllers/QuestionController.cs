using HYSABAT.Controllers.Data;
using HYSABAT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HYSABAT.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _db;
        public QuestionController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Question> obj = _db.questions.ToList();
            return View(obj);
        }
        [HttpPost]
        public IActionResult CreateQuestion(Question model )
        {
            if (ModelState.IsValid)
            {
                _db.questions.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult DeleteQuestion( int? id, Question model)
        {
            var obj = _db.questions.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.questions.Remove(obj);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateQuestion(Question model)
        {
            if (ModelState.IsValid)
            {
                _db.questions.Update(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
