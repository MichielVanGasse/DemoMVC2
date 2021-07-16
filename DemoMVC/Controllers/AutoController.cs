
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View(AutoData.autolijst);
        }
        public IActionResult Detail(int id)
        {
            return View(AutoData.autolijst.Find(x => x.Id == id));
        }
        public IActionResult AddAuto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAuto(AutoModel auto)
        {
            if (ModelState.IsValid)
            {
                AutoData.autolijst.Add(auto);
                return RedirectToAction("Detail", new { id = auto.Id });
            }
            return View(auto);
        }
    }
}
