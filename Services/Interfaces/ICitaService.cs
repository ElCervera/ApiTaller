using ApiTaller.Models;

namespace ApiTaller.Services.Interfaces
{
    public interface ICitaService
    {
        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita> GetCitaById(long id);
        Task AddCita(Cita cita);
        Task UpdateCita(Cita cita);
        Task DeleteCita(long id);
    }
}
