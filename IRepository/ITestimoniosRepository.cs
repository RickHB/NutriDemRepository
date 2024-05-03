using NutridemApp.Models;

namespace NutridemApp.IRepository
{
    public interface ITestimoniosRepository
    {
        Task<int> AgregarTestimonioAsync(Testimonios testimonios);

    }
}
