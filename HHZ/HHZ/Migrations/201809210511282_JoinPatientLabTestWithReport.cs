namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientLabTestWithReport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientLabTests", "PatientReportDetailId", c => c.Int(nullable: false));
            AddColumn("dbo.PatientReportDetails", "PatientLabTestId", c => c.Int());
            CreateIndex("dbo.PatientReportDetails", "PatientLabTestId");
            AddForeignKey("dbo.PatientReportDetails", "PatientLabTestId", "dbo.PatientLabTests", "PatientLabTestId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientReportDetails", "PatientLabTestId", "dbo.PatientLabTests");
            DropIndex("dbo.PatientReportDetails", new[] { "PatientLabTestId" });
            DropColumn("dbo.PatientReportDetails", "PatientLabTestId");
            DropColumn("dbo.PatientLabTests", "PatientReportDetailId");
        }
    }
}
