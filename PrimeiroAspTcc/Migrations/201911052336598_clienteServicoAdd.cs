namespace PrimeiroAspTcc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clienteServicoAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteServicoes",
                c => new
                    {
                        ClienteServicoId = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        TipoServicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteServicoId);
            
            AddColumn("dbo.Clientes", "ClienteServico_ClienteServicoId", c => c.Int());
            AddColumn("dbo.TipoServicoes", "ClienteServico_ClienteServicoId", c => c.Int());
            CreateIndex("dbo.Clientes", "ClienteServico_ClienteServicoId");
            CreateIndex("dbo.TipoServicoes", "ClienteServico_ClienteServicoId");
            AddForeignKey("dbo.Clientes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes", "ClienteServicoId");
            AddForeignKey("dbo.TipoServicoes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes", "ClienteServicoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoServicoes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes");
            DropForeignKey("dbo.Clientes", "ClienteServico_ClienteServicoId", "dbo.ClienteServicoes");
            DropIndex("dbo.TipoServicoes", new[] { "ClienteServico_ClienteServicoId" });
            DropIndex("dbo.Clientes", new[] { "ClienteServico_ClienteServicoId" });
            DropColumn("dbo.TipoServicoes", "ClienteServico_ClienteServicoId");
            DropColumn("dbo.Clientes", "ClienteServico_ClienteServicoId");
            DropTable("dbo.ClienteServicoes");
        }
    }
}
