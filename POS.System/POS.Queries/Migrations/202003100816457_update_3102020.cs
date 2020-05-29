namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_3102020 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductLogs",
                c => new
                    {
                        ProductLogID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Action = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.ProductLogID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductLogs", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductLogs", new[] { "ProductID" });
            DropTable("dbo.ProductLogs");
        }
    }
}
