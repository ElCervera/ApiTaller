using ApiTaller.Models;

namespace ApiTaller.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllCliente();
        Task<Cliente> GetClienteById(long id);
        Task AddCliente(Cliente cliente);
        Task UpdateCliente(Cliente cliente);
        Task DeleteCliente(long id);
    }
}
