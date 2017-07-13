
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces;
using System.Collections.Generic;

namespace ProjetoModeloDD.Domain.Interfaces.Repositories
{
    //Aqui estamos fazendo o contrato para que os Repositories assinem esse contrato
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string nome);
    }
}
