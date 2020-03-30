namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientWithPatientPqrs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientPqrs", "PatientId", c => c.Int());
            AddColumn("dbo.Patients", "PatientPqrsId", c => c.Int(nullable: false));
            CreateIndex("dbo.PatientPqrs", "PatientId");
            AddForeignKey("dbo.PatientPqrs", "PatientId", "dbo.Patients", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientPqrs", "PatientId", "dbo.Patients");
            DropIndex("dbo.PatientPqrs", new[] { "PatientId" });
            DropColumn("dbo.Patients", "PatientPqrsId");
            DropColumn("dbo.PatientPqrs", "PatientId");
        }
    }
}
