using ApiTaller.Models;

namespace ApiTaller.Services.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllCliente(); 
        Task<Cliente> GetClienteById(long id);
        Task AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(long id);
    }
}
