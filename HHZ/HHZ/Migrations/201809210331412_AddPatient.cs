namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        RegId = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        MaritalStatus = c.Boolean(nullable: false),
                        SpouseName = c.String(),
                        Children = c.Byte(nullable: false),
                        Cast = c.String(),
                        DOB = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Religion = c.String(),
                        Occupation = c.String(),
                        Designation = c.String(),
                        Sufferingfrom = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Cnic = c.Int(nullable: false),
                        PhysicalAddress = c.String(),
                        PostalAddress = c.String(),
                        ZipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
