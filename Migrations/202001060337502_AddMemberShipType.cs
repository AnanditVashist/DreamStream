namespace DreamStream.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SignupFee = c.Int(nullable: false),
                        DurationInMonths = c.Int(nullable: false),
                        DiscountRate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershiptypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MembershiptypeId");
            AddForeignKey("dbo.Customers", "MembershiptypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershiptypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershiptypeId" });
            DropColumn("dbo.Customers", "MembershiptypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
