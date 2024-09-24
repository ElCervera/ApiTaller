using ApiTaller.Models;
using ApiTaller.Repositories.Interfaces;
using ApiTaller.Services.Interfaces;

namespace ApiTaller.Services.Implementations
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> GetAllCliente()
        {
            return await _clienteRepository.GetAllCliente();
        }

        public async Task<Cliente> GetClienteById(long id)
        {
            return await _clienteRepository.GetClienteById(id);
        }

        public async Task AddCliente(Cliente cliente)
        {
            await _clienteRepository.AddCliente(cliente);
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            await _clienteRepository.UpdateCliente(cliente);
        }

        public async Task DeleteCita(long id)
    {
            await _clienteRepository.DeleteCliente(id);
        }
    }
}
