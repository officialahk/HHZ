namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientPqrs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientPqrs",
                c => new
                    {
                        PatientPqrsId = c.Int(nullable: false, identity: true),
                        Peculiar = c.String(),
                        Queer = c.String(),
                        Rare = c.String(),
                        Strange = c.String(),
                        Like = c.String(),
                        Dislike = c.String(),
                    })
                .PrimaryKey(t => t.PatientPqrsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatientPqrs");
        }
    }
}
