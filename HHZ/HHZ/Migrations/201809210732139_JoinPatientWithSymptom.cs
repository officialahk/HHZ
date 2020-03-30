namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientWithSymptom : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "PatientSymptomId", c => c.Int(nullable: false));
            AddColumn("dbo.PatientSymptoms", "PatientId", c => c.Int());
            CreateIndex("dbo.PatientSymptoms", "PatientId");
            AddForeignKey("dbo.PatientSymptoms", "PatientId", "dbo.Patients", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientSymptoms", "PatientId", "dbo.Patients");
            DropIndex("dbo.PatientSymptoms", new[] { "PatientId" });
            DropColumn("dbo.PatientSymptoms", "PatientId");
            DropColumn("dbo.Patients", "PatientSymptomId");
        }
    }
}
