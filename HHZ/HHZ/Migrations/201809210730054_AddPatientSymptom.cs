namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientSymptom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientSymptoms",
                c => new
                    {
                        PatientSymptomId = c.Int(nullable: false, identity: true),
                        SymptomName = c.String(),
                        Intensity = c.String(),
                        Duration = c.Byte(nullable: false),
                        InTermOf = c.String(),
                    })
                .PrimaryKey(t => t.PatientSymptomId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientSymptoms");
        }
    }
}
