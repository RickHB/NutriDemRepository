using Microsoft.AspNetCore.Mvc;
using NutridemApp.Models;
using System.Diagnostics;

namespace NutridemApp.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Informacion()
        {
            return View("InfoIndex");
        }
    }
}
