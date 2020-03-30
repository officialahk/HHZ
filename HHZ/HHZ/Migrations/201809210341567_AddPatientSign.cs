namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientSign : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientSigns",
                c => new
                    {
                        PatientSignId = c.Int(nullable: false, identity: true),
                        SignId = c.Int(nullable: false),
                        SignsValueId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientSignId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientSigns");
        }
    }
}
