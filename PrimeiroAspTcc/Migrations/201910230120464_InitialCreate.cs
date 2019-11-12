namespace PrimeiroAspTcc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50),
                        Data_nasc = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 40),
                        Cpf = c.String(maxLength: 18),
                        Rg = c.String(maxLength: 13),
                        Sexo = c.Int(nullable: false),
                        Ender_resi_Rua = c.String(maxLength: 50),
                        Ender_resi_Bairro = c.String(maxLength: 50),
                        Ender_resi_Cidade = c.String(maxLength: 50),
                        Ender_resi_Numero = c.String(maxLength: 9),
                        Ender_resi_Cep = c.String(maxLength: 20),
                        Ender_resi_Latitude = c.Single(nullable: false),
                        Ender_resi_Longitude = c.Single(nullable: false),
                        End_comercial_Rua = c.String(maxLength: 50),
                        End_comercial_Bairro = c.String(maxLength: 50),
                        End_comercial_Cidade = c.String(maxLength: 50),
                        End_comercial_Numero = c.String(maxLength: 9),
                        End_comercial_Cep = c.String(maxLength: 20),
                        End_comercial_Latitude = c.Single(nullable: false),
                        End_comercial_Longitude = c.Single(nullable: false),
                        Cel = c.String(maxLength: 11),
                        Login = c.String(maxLength: 40),
                        Senha = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoServicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 50),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoServicoClientes",
                c => new
                    {
                        TipoServico_Id = c.Int(nullable: false),
                        Cliente_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TipoServico_Id, t.Cliente_Id })
                .ForeignKey("dbo.TipoServicoes", t => t.TipoServico_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id, cascadeDelete: true)
                .Index(t => t.TipoServico_Id)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TipoServicoClientes", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.TipoServicoClientes", "TipoServico_Id", "dbo.TipoServicoes");
            DropIndex("dbo.TipoServicoClientes", new[] { "Cliente_Id" });
            DropIndex("dbo.TipoServicoClientes", new[] { "TipoServico_Id" });
            DropTable("dbo.TipoServicoClientes");
            DropTable("dbo.TipoServicoes");
            DropTable("dbo.Clientes");
        }
    }
}
