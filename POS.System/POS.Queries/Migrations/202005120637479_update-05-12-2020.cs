namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update05122020 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PosTransactions", "MemberID", "dbo.Members");
            DropIndex("dbo.PosTransactions", new[] { "MemberID" });
            AlterColumn("dbo.PosTransactions", "MemberID", c => c.Int(nullable: false));
            CreateIndex("dbo.PosTransactions", "MemberID");
            AddForeignKey("dbo.PosTransactions", "MemberID", "dbo.Members", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PosTransactions", "MemberID", "dbo.Members");
            DropIndex("dbo.PosTransactions", new[] { "MemberID" });
            AlterColumn("dbo.PosTransactions", "MemberID", c => c.Int());
            CreateIndex("dbo.PosTransactions", "MemberID");
            AddForeignKey("dbo.PosTransactions", "MemberID", "dbo.Members", "MemberID");
        }
    }
}
