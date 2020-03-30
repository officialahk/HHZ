namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientLabTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientLabTests",
                c => new
                    {
                        PatientLabTestId = c.Int(nullable: false, identity: true),
                        TestName = c.String(),
                        DoctorRemarks = c.String(),
                        TestDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        LabName = c.String(),
                    })
                .PrimaryKey(t => t.PatientLabTestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientLabTests");
        }
    }
}
