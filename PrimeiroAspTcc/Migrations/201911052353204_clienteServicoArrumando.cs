namespace PrimeiroAspTcc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clienteServicoArrumando : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes");
            DropForeignKey("dbo.TipoServicoes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes");
            DropIndex("dbo.Clientes", new[] { "ClienteServico_ClienteServicoId" });
            DropIndex("dbo.TipoServicoes", new[] { "ClienteServico_ClienteServicoId" });
            CreateIndex("dbo.ClienteServicoes", "ClienteId");
            CreateIndex("dbo.ClienteServicoes", "TipoServicoId");
            AddForeignKey("dbo.ClienteServicoes", "ClienteId", "dbo.Clientes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClienteServicoes", "TipoServicoId", "dbo.TipoServicoes", "Id", cascadeDelete: true);
            DropColumn("dbo.Clientes", "ClienteServico_ClienteServicoId");
            DropColumn("dbo.TipoServicoes", "ClienteServico_ClienteServicoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TipoServicoes", "ClienteServico_ClienteServicoId", c => c.Int());
            AddColumn("dbo.Clientes", "ClienteServico_ClienteServicoId", c => c.Int());
            DropForeignKey("dbo.ClienteServicoes", "TipoServicoId", "dbo.TipoServicoes");
            DropForeignKey("dbo.ClienteServicoes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.ClienteServicoes", new[] { "TipoServicoId" });
            DropIndex("dbo.ClienteServicoes", new[] { "ClienteId" });
            CreateIndex("dbo.TipoServicoes", "ClienteServico_ClienteServicoId");
            CreateIndex("dbo.Clientes", "ClienteServico_ClienteServicoId");
            AddForeignKey("dbo.TipoServicoes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes", "ClienteServicoId");
            AddForeignKey("dbo.Clientes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes", "ClienteServicoId");
        }
    }
}
