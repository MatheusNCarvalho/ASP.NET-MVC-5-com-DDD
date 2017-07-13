

using ProjetoModeloDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Valor)
               .IsRequired();

            //Criando a Relação, //p é a propriadade
            HasRequired(p => p.Cliente)//Apontado para Cliente
                .WithMany() // Falando que Cliente tem muitos produtos
                .HasForeignKey(p => p.ClienteId); // fk da tabela

        }
    }
}
