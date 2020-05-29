namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PosTransaction_IsComplete : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PosTransactions", "IsComplete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PosTransactions", "IsComplete");
        }
    }
}
