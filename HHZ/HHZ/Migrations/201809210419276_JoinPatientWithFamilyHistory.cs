namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientWithFamilyHistory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientFamilyHistories", "PatientId", c => c.Int());
            AddColumn("dbo.Patients", "PatientFamilyHistoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.PatientFamilyHistories", "PatientId");
            AddForeignKey("dbo.PatientFamilyHistories", "PatientId", "dbo.Patients", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientFamilyHistories", "PatientId", "dbo.Patients");
            DropIndex("dbo.PatientFamilyHistories", new[] { "PatientId" });
            DropColumn("dbo.Patients", "PatientFamilyHistoryId");
            DropColumn("dbo.PatientFamilyHistories", "PatientId");
        }
    }
}
