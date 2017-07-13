using System;
using System.Collections.Generic;
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Repositories;
using ProjetoModeloDD.Domain.Interfaces.Services;
using System.Linq;

namespace ProjetoModeloDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRespository _clienteRespository;

        public ClienteService(IClienteRespository clienteRespository)
            :base(clienteRespository)
        {
            _clienteRespository = clienteRespository;
        }


        public IEnumerable<Cliente> obterClienteEspeciais(IEnumerable<Cliente> cliente)
        {
            return cliente.Where(c => c.ClienteEspecial(c));
        }
    }
}
