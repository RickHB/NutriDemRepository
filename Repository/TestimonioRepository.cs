using NutridemApp.IRepository;
using NutridemApp.Models;
using System.Threading.Tasks;

namespace NutridemApp.Repository
{
    public class TestimonioRepository : ITestimoniosRepository
    {
        private readonly ApplicationDbContext _context;

        public TestimonioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AgregarTestimonioAsync(Testimonios testimonios)
        {
            _context.Testimonios.Add(testimonios);
            await _context.SaveChangesAsync();
            return testimonios.Id;
        }
    }
}
