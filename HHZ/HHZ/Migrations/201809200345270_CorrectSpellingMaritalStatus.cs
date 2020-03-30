namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectSpellingMaritalStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "MaritalStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Doctors", "MaterialStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "MaterialStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Doctors", "MaritalStatus");
        }
    }
}
