using ApiTaller.Models;
using ApiTaller.Repositories.Interfaces;
using ApiTaller.Services.Interfaces;

namespace ApiTaller.Services.Implementations
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _citaRepository;

        public CitaService(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _citaRepository.GetAllCitas();
        }

        public async Task<Cita> GetCitaById(long id)
        {
            return await _citaRepository.GetCitaById(id);
        }

        public async Task AddCita(Cita cita)
        {
            await _citaRepository.AddCita(cita);
        }

        public async Task UpdateCita(Cita cita)
        {
            await _citaRepository.UpdateCita(cita);
        }

        public async Task DeleteCita(long id)
        {
            await _citaRepository.DeleteCita(id);
        }
    }
}
