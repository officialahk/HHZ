namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientPastHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientPastHistories",
                c => new
                    {
                        PatientPastHistoryId = c.Int(nullable: false, identity: true),
                        Disease = c.String(),
                        Age = c.Byte(nullable: false),
                        Duration = c.Byte(nullable: false),
                        InTermOf = c.String(),
                        Medication = c.String(),
                    })
                .PrimaryKey(t => t.PatientPastHistoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientPastHistories");
        }
    }
}
