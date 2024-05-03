using Microsoft.AspNetCore.Mvc;
using NutridemApp.IRepository;
using NutridemApp.Models;
using NutridemApp.Repository;
using System.Diagnostics;

namespace NutridemApp.Controllers
{
    public class TestimoniosController : Controller
    {
        private readonly ITestimoniosRepository _testimonioRepository;

        public TestimoniosController(ITestimoniosRepository testimonioRepository)
        {
            _testimonioRepository = testimonioRepository;
        }

        public IActionResult Testimonios()
        {
            return View("TestIndex");
        }
        [HttpPost]
        public async Task<IActionResult> AgregarTestimonio(Testimonios testimonios)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _testimonioRepository.AgregarTestimonioAsync(testimonios);
                }
                return View("TestIndex");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}