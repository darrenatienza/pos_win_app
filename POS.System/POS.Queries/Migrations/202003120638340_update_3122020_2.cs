namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_3122020_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PosTransactions", "MemberID", c => c.Int());
            CreateIndex("dbo.PosTransactions", "MemberID");
            AddForeignKey("dbo.PosTransactions", "MemberID", "dbo.Members", "MemberID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PosTransactions", "MemberID", "dbo.Members");
            DropIndex("dbo.PosTransactions", new[] { "MemberID" });
            DropColumn("dbo.PosTransactions", "MemberID");
        }
    }
}
