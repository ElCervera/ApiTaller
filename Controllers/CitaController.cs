using Microsoft.AspNetCore.Mvc;
using ApiTaller.Models;
using ApiTaller.Services.Interfaces;

namespace ApiTaller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        private readonly ICitaService _citaService;

        public CitaController(ICitaService citaService)
        {
            _citaService = citaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCitas()
        {
            var citas = await _citaService.GetAllCitas();
            return Ok(citas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCitaById(long id)
        {
            var cita = await _citaService.GetCitaById(id);
            if (cita == null)
                return NotFound();

            return Ok(cita);
        }

        [HttpPost]
        public async Task<IActionResult> AddCita([FromBody] Cita cita)
        {
            await _citaService.AddCita(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.Id }, cita);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCita(long id, [FromBody] Cita cita)
        {
            var existingCita = await _citaService.GetCitaById(id);
            if (existingCita == null)
                return NotFound();

            await _citaService.UpdateCita(cita);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCita(long id)
        {
            await _citaService.DeleteCita(id);
            return NoContent();
        }
    }
}
