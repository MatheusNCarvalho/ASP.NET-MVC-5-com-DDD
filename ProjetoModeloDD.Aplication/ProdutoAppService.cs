
using ProjetoModeloDD.Aplication.Interface;
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Services;
using System.Collections.Generic;
using System;

namespace ProjetoModeloDD.Aplication
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {

        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            :base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return _produtoService.BuscaPorNome(nome);
        }
    }
}
