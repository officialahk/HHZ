namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JoinPatientWithPastHistory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientPastHistories", "PatientId", c => c.Int());
            AddColumn("dbo.Patients", "PatientPastHistoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.PatientPastHistories", "PatientId");
            AddForeignKey("dbo.PatientPastHistories", "PatientId", "dbo.Patients", "PatientId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientPastHistories", "PatientId", "dbo.Patients");
            DropIndex("dbo.PatientPastHistories", new[] { "PatientId" });
            DropColumn("dbo.Patients", "PatientPastHistoryId");
            DropColumn("dbo.PatientPastHistories", "PatientId");
        }
    }
}
