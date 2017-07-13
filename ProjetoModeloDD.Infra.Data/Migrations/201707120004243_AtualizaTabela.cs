namespace ProjetoModeloDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizaTabela : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            AlterColumn("dbo.Cliente", "Nome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Sobrenome", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Cliente", "Email", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Email", c => c.String());
            AlterColumn("dbo.Cliente", "Sobrenome", c => c.String());
            AlterColumn("dbo.Cliente", "Nome", c => c.String());
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
        }
    }
}
