namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePatientSign : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientSigns", "SignName", c => c.String());
            AddColumn("dbo.PatientSigns", "SignsValueName", c => c.String());
            DropColumn("dbo.PatientSigns", "SignId");
            DropColumn("dbo.PatientSigns", "SignsValueId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientSigns", "SignsValueId", c => c.Int(nullable: false));
            AddColumn("dbo.PatientSigns", "SignId", c => c.Int(nullable: false));
            DropColumn("dbo.PatientSigns", "SignsValueName");
            DropColumn("dbo.PatientSigns", "SignName");
        }
    }
}
