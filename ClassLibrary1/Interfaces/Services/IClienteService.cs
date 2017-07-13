
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        //Aqui eu tá falando quando eu for implementar, tem que retornar os clientes especiais
        IEnumerable<Cliente> obterClienteEspeciais(IEnumerable<Cliente> cliente);
    }
}
