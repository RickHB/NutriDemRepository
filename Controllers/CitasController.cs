using Microsoft.AspNetCore.Mvc;
using NutridemApp.IRepository;
using NutridemApp.Models;
using System.Diagnostics;

namespace NutridemApp.Controllers
{
    public class CitasController : Controller
    {
        private readonly ICitasRepository _citasRepository;

        public CitasController(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }
        public IActionResult Citas()
        {
            return View("CitasIndex");
        }

        [HttpPost]
        public async Task<IActionResult> AgregarCita(Citas cita)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _citasRepository.AgregarCitaAsync(cita);
                }
                return View("CitasIndex");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

    }
}
