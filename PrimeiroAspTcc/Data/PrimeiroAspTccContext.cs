using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PrimeiroAspTcc.Data
{
    public class PrimeiroAspTccContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PrimeiroAspTccContext() : base("name=PrimeiroAspTccContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
         //   dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<PrimeiroAspTcc.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<PrimeiroAspTcc.Models.TipoServico> TipoServicoes { get; set; }
        public DbSet<PrimeiroAspTcc.Models.ClienteServico> ClienteServico { get; set; }
    }
}
