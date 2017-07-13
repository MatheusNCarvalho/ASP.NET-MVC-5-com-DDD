
using System;

using System.Collections.Generic;

namespace ProjetoModeloDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        public string Email { get; set; }

        public DateTime DataCadastrado { get; set; }

        public bool Ativo { get; set; }

        //Coleção de Produtos
        public virtual IEnumerable<Produto> Produtos { get; set; }


        //Regra de Negocio
        public bool ClienteEspecial(Cliente cliente)
        {
            //Quando um cliente tiver um cadastrado maior do que 5 anos
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastrado.Year >= 5;
        }
    }
}
