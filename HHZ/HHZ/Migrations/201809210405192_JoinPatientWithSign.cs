namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientWithSign : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "PatientSignId", c => c.Int(nullable: false));
            AddColumn("dbo.PatientSigns", "PatientId", c => c.Int());
            CreateIndex("dbo.PatientSigns", "PatientId");
            AddForeignKey("dbo.PatientSigns", "PatientId", "dbo.Patients", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientSigns", "PatientId", "dbo.Patients");
            DropIndex("dbo.PatientSigns", new[] { "PatientId" });
            DropColumn("dbo.PatientSigns", "PatientId");
            DropColumn("dbo.Patients", "PatientSignId");
        }
    }
}
