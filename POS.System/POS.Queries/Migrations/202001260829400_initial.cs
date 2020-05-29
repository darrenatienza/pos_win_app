namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChatMessages",
                c => new
                    {
                        ChatMessageID = c.Int(nullable: false, identity: true),
                        UserNameSender = c.String(),
                        UserNameReciever = c.String(),
                        Message = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        CreateDateTime = c.DateTime(nullable: false),
                        IsNotified = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ChatMessageID);
            
            CreateTable(
                "dbo.PosTransactions",
                c => new
                    {
                        POSTransactionID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        TransactionCode = c.String(),
                        AmountTender = c.Double(),
                    })
                .PrimaryKey(t => t.POSTransactionID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Description = c.String(),
                        Price = c.Double(),
                        Quantity = c.Int(nullable: false),
                        Limit = c.Int(nullable: false),
                        Remarks = c.String(),
                        SupplierID = c.Int(nullable: false),
                        CreateTimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Suppliers", t => t.SupplierID, cascadeDelete: true)
                .Index(t => t.SupplierID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Address = c.String(),
                        Remarks = c.String(),
                        CreateTimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false),
                        PasswordSalt = c.String(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        MiddleName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false, maxLength: 250),
                        IsOnline = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        RoleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.RoleID })
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "UserID", "dbo.Users");
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropIndex("dbo.UserRoles", new[] { "RoleID" });
            DropIndex("dbo.UserRoles", new[] { "UserID" });
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.PosTransactions");
            DropTable("dbo.ChatMessages");
        }
    }
}
