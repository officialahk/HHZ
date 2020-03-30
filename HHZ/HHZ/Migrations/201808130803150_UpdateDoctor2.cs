namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDoctor2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doctors", "DoctorExperienceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "DoctorExperienceId", c => c.Int(nullable: false));
        }
    }
}
