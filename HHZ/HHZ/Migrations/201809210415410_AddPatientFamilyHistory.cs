namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientFamilyHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientFamilyHistories",
                c => new
                    {
                        PatientFamilyHistoryId = c.Int(nullable: false, identity: true),
                        Relation = c.String(),
                        Count = c.Byte(nullable: false),
                        Alive = c.Int(nullable: false),
                        Dead = c.Int(nullable: false),
                        DeathAge = c.Byte(nullable: false),
                        ReasionOfDeath = c.String(),
                        SufferingFrom = c.String(),
                    })
                .PrimaryKey(t => t.PatientFamilyHistoryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientFamilyHistories");
        }
    }
}
