using NutridemApp.Models;

namespace NutridemApp.IRepository
{
    public interface ICitasRepository
    {
      
        Task<int> AgregarCitaAsync(Citas cita);
    }

}
