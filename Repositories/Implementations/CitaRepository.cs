using Microsoft.EntityFrameworkCore;
using ApiTaller.Data;
using ApiTaller.Models;
using ApiTaller.Repositories.Interfaces;

namespace ApiTaller.Repositories.Implementations
{
    public class CitaRepository : ICitaRepository
    {
        private readonly ApplicationDbContext _context;

        public CitaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cita>> GetAllCitas()
        {
            return await _context.Citas.ToListAsync();
        }

        public async Task<Cita> GetCitaById(long id)
        {
            return await _context.Citas.FindAsync(id);
        }

        public async Task AddCita(Cita cita)
        {
            await _context.Citas.AddAsync(cita);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCita(Cita cita)
        {
            _context.Citas.Update(cita);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCita(long id)
        {
            var cita = await _context.Citas.FindAsync(id);
            if (cita != null)
            {
                _context.Citas.Remove(cita);
                await _context.SaveChangesAsync();
            }
        }
    }
}
