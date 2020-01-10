namespace DreamStream.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Pay as you go' WHERE Id='1'");
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Monthly' WHERE Id='2'");
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Quarterly' WHERE Id='3'");
            Sql("UPDATE MEMBERSHIPTYPES SET Name='Yearly' WHERE Id='4'");
            
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
