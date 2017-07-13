using System;
using System.Collections.Generic;
using ProjetoModeloDD.Aplication.Interface;
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Services;

namespace ProjetoModeloDD.Aplication
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            :base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> obterClienteEspecias()
        {
            return _clienteService.obterClienteEspeciais(_clienteService.GetAll());
        }
    }
}
