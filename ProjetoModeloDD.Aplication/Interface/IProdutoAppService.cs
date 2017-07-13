

using ProjetoModeloDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDD.Aplication.Interface
{
   public  interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
