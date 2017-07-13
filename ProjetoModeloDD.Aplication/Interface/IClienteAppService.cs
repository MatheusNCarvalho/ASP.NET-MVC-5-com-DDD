
using ProjetoModeloDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDD.Aplication.Interface
{
   public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> obterClienteEspecias();
    }
}
