namespace PrimeiroAspTcc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaClienteServico : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TipoServicoClientes", "TipoServico_Id", "dbo.TipoServicoes");
            DropForeignKey("dbo.TipoServicoClientes", "Cliente_Id", "dbo.Clientes");
            DropIndex("dbo.TipoServicoClientes", new[] { "TipoServico_Id" });
            DropIndex("dbo.TipoServicoClientes", new[] { "Cliente_Id" });
            DropTable("dbo.TipoServicoClientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TipoServicoClientes",
                c => new
                    {
                        TipoServico_Id = c.Int(nullable: false),
                        Cliente_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TipoServico_Id, t.Cliente_Id });
            
            CreateIndex("dbo.TipoServicoClientes", "Cliente_Id");
            CreateIndex("dbo.TipoServicoClientes", "TipoServico_Id");
            AddForeignKey("dbo.TipoServicoClientes", "Cliente_Id", "dbo.Clientes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TipoServicoClientes", "TipoServico_Id", "dbo.TipoServicoes", "Id", cascadeDelete: true);
        }
    }
}
