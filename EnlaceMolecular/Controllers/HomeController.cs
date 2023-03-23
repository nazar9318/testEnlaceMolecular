using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EnlaceMolecular.Controllers
{
    public class HomeController : Controller {
        public IActionResult Index(string text) {
            WordCounter counter = new WordCounter(text);
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
