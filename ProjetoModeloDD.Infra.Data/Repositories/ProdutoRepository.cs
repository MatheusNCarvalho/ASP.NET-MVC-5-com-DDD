
using System.Linq;
using System.Collections.Generic;
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);

        }
    }
}
