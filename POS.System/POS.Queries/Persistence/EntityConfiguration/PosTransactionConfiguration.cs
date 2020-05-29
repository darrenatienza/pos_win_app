using POS.Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Queries.EntityConfiguration
{
    public class PosTransactionConfiguration : EntityTypeConfiguration<PosTransaction>
    {
        public PosTransactionConfiguration()
        {





            //HasMany(u => u.Products)
            //    .WithMany(p => p.PosTransactions)
            //    .Map(m =>
            //    {
            //        m.ToTable("PosTransactionProducts");
            //        m.MapLeftKey("PosTransactionID");
            //        m.MapRightKey("ProductID");
            //    });
                
        }

        
    }
}
