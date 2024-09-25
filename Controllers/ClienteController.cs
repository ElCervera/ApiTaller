using Microsoft.AspNetCore.Mvc;
using ApiTaller.Models;
using ApiTaller.Services.Interfaces;
//ejemplo
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
            var citas = await _clienteService.GetAllCliente();
            return Ok(citas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCitaById(long id)
        {
            var cita = await _clienteService.GetClienteById(id);
            if (cita == null)
                return NotFound();

            return Ok(cita);
        }

        [HttpPost]
        public async Task<IActionResult> AddCita([FromBody] Cita cita)
        {
            await _clienteService.AddCliente(cliente);
            return CreatedAtAction(nameof(GetCitaById), new { id = cita.Id }, cita);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCita(long id, [FromBody] Cita cita)
        {
            var existingCita = await _clienteService.GetClienteById(id);
            if (existingCita == null)
                return NotFound();

            await _clienteService.UpdateCliente(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCita(long id)
    {
            await _clienteService.DeleteCliente(id);
            return NoContent();
        }
    }
}
