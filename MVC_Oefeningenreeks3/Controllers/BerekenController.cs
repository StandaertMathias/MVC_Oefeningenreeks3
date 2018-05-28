using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oefeningenreeks1;

namespace MVC_Oefeningenreeks3.Controllers
{
    [Route("Bereken")]
    public class BerekenController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Faculteit/{getal}")]
        public IActionResult berekenFaculteit(int getal)
        {
            Faculteit faculty = new Faculteit(getal);
            ViewBag.opl = faculty.Bereken();
            return View();
        }
        [Route("Temperatuur/in{eenheid}/{waarde}")]
        public IActionResult berekenTemperatuur(string eenheid, int waarde)
        {
            Temperatuur temp = new Temperatuur(waarde);
            if (eenheid == "Kelvin")
            {
                ViewBag.opl = temp.Kelvin;
            }else if (eenheid == "Fahrenheit")
            {
                ViewBag.opl = temp.Fahrenheit;
            }
            return View();
        }
    }
}