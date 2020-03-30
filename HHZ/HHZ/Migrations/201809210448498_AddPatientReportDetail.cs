namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientReportDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientReportDetails",
                c => new
                    {
                        PatientReportDetailId = c.Int(nullable: false, identity: true),
                        ParameterName = c.Int(nullable: false),
                        ParameterValues = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientReportDetailId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientReportDetails");
        }
    }
}
