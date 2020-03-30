namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientWithPatientLabTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientLabTests", "PatientId", c => c.Int());
            AddColumn("dbo.Patients", "PatientLabTestId", c => c.Int(nullable: false));
            CreateIndex("dbo.PatientLabTests", "PatientId");
            AddForeignKey("dbo.PatientLabTests", "PatientId", "dbo.Patients", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientLabTests", "PatientId", "dbo.Patients");
            DropIndex("dbo.PatientLabTests", new[] { "PatientId" });
            DropColumn("dbo.Patients", "PatientLabTestId");
            DropColumn("dbo.PatientLabTests", "PatientId");
        }
    }
}
