using NutridemApp.IRepository;
using NutridemApp.Models;

namespace NutridemApp.Repository
{
    public class CitasRepository : ICitasRepository
    {
        private readonly ApplicationDbContext _context;

        public CitasRepository(ApplicationDbContext context)
        {
            _context = context;
        }

 
        public async Task<int> AgregarCitaAsync(Citas cita)
        {
            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();
            return cita.Id;
        }
    }

}
