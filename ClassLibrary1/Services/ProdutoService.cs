using System;
using System.Collections.Generic;
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Repositories;
using ProjetoModeloDD.Domain.Interfaces.Services;

namespace ProjetoModeloDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRespository;

        public ProdutoService(IProdutoRepository produtoRespository)
            :base(produtoRespository)
        {
            _produtoRespository = produtoRespository;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoRespository.BuscaPorNome(nome);
        }
    }
}
