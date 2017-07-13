using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDD.Infra.Data.Repositories
{
    //Aqui vou fazer as consultas mais especifacaas
   public  class ClienteRepository : RepositoryBase<Cliente>, IClienteRespository
    {

    }
}
