using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EnlaceMolecular.Models;

namespace EnlaceMolecular.Controllers
{
    public class HomeController : Controller {

        //GET
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string text) {
            WordCounter counter = new WordCounter(text);
            ViewBag.Message = counter.getCount();
            return View();
        }

        public IActionResult About() {
            ViewData["Message"] = "Bienvenido al contador de palabras de Federico Elías, para Enlace Molecular";
            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}
