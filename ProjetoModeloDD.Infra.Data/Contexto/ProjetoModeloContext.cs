
using ProjetoModeloDD.Domain.Entities;
using ProjetoModeloDD.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoModeloDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext       
    {
        public ProjetoModeloContext() : base("ProjetoModeloDDD")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Desabilitando conversoes
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            //Quando voce estiver algumas com Id no final da propriedade seta ela com primary key
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());
            // ---------- -

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

          //  modelBuilder.Properties<DateTime>()
            //    .Configure(p => p.HasColumnType("datetime2(7)"));

            modelBuilder.Configurations.Add(new ClienteConfiguration()); //Aqui pega as novas configuração
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        //Sobrescrevendo o Metado SaveChanges, para que quando for salvar, já pegar a data de cadastrado
       public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("DataCadastrado") == null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastrado").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastrado").IsModified = false;
                }


            }
            return base.SaveChanges();
        }
        // -------- 

    }

    
}
