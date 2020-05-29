namespace POS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_3122020 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Address = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.MemberID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
