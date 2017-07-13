using ProjetoModeloDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);

    }
}
