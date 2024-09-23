using ApiTaller.Models;

namespace ApiTaller.Repositories.Interfaces
{
    public interface ICitaRepository
    {
        Task<IEnumerable<Cita>> GetAllCitas();
        Task<Cita> GetCitaById(long id);
        Task AddCita(Cita cita);
        Task UpdateCita(Cita cita);
        Task DeleteCita(long id);
    }
}
