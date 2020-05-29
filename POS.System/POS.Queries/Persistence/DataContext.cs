using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POS.Queries.Core.Domain;
using POS.Queries.Migrations;
using POS.Queries.EntityConfiguration;
using System.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
namespace POS.Queries.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext()
            //: base("DataContext")

            : base("ReleaseContext")
            //: base("ServerContext")
        {
            //AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            this.Configuration.LazyLoadingEnabled = false;
          
            
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<PosTransaction> PosTransactions { get; set; }
        public virtual DbSet<PosTransactionProduct> PosTransactionProducts { get; set; }
        public virtual DbSet<ChatMessage> ChatMessages { get; set; }
        public virtual DbSet<ProductLog> ProductLogs { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());

            //modelBuilder.Configurations.Add(new PosTransactionConfiguration());
        }
    }
}
