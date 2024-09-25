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
        public async Task<IActionResult> GetAllCliente()
        {
            var cliente = await _clienteService.GetAllCliente();
            return Ok(cliente);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClienteById(long id)
        {
            var cliente = await _clienteService.GetClienteById(id);
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> AddCliente([FromBody] Cliente cliente)
        {
            await _clienteService.AddCliente(cliente);
            return CreatedAtAction(nameof(GetClienteById), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCliente(long id, [FromBody] Cliente cliente)
        {
            var existingCliente = await _clienteService.GetClienteById(id);
            if (existingCliente == null)
                return NotFound();

            await _clienteService.UpdateCliente(cliente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(long id)
    {
            await _clienteService.DeleteCliente(id);
            return NoContent();
        }
    }
}
