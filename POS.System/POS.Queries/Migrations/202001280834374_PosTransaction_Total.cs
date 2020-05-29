namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PosTransaction_Total : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PosTransactions", "Total", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PosTransactions", "Total");
        }
    }
}
