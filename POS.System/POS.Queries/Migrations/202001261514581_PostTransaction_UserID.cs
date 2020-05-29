namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostTransaction_UserID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PosTransactions", "UserID", c => c.Int());
            CreateIndex("dbo.PosTransactions", "UserID");
            AddForeignKey("dbo.PosTransactions", "UserID", "dbo.Users", "UserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PosTransactions", "UserID", "dbo.Users");
            DropIndex("dbo.PosTransactions", new[] { "UserID" });
            DropColumn("dbo.PosTransactions", "UserID");
        }
    }
}
