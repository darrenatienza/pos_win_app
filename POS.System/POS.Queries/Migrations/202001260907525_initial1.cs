namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PosTransactionProducts",
                c => new
                    {
                        PosTransactionProductID = c.Int(nullable: false, identity: true),
                        PosTransactionID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PosTransactionProductID)
                .ForeignKey("dbo.PosTransactions", t => t.PosTransactionID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.PosTransactionID)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PosTransactionProducts", "ProductID", "dbo.Products");
            DropForeignKey("dbo.PosTransactionProducts", "PosTransactionID", "dbo.PosTransactions");
            DropIndex("dbo.PosTransactionProducts", new[] { "ProductID" });
            DropIndex("dbo.PosTransactionProducts", new[] { "PosTransactionID" });
            DropTable("dbo.PosTransactionProducts");
        }
    }
}
