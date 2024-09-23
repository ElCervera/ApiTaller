using Microsoft.AspNetCore.Mvc;
using ApiTaller.Models;
using ApiTaller.Services.Interfaces;

namespace ApiTaller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCitas()
        {
            var citas = await _clienteService.GetAllCitas();
            return Ok(citas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCitaById(long id)
        {
            var cita = await _clienteService.GetCitaById(id);
            if (cita == null)
                return NotFound();

            return Ok(cita);
        }

        [HttpPost]
        public async Task<IActionResult> AddCita([FromBody] Cita cita)
        {
            await _clienteService.AddCliente(cita);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.Id }, cita);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCita(long id, [FromBody] Cita cita)
        {
            var existingCita = await _clienteService.GetCitaById(id);
            if (existingCita == null)
                return NotFound();

            await _clienteService.UpdateCita(cita);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCita(long id)
        {
            await _clienteService.DeleteCita(id);
            return NoContent();
        }
    }
}
