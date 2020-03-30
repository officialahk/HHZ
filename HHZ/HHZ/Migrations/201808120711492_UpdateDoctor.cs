namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDoctor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId", c => c.Byte());
            CreateIndex("dbo.Doctors", "DoctorTypeId");
            CreateIndex("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId");
            AddForeignKey("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId", "dbo.DoctorSpecializations", "DoctorSpecializationId");
            AddForeignKey("dbo.Doctors", "DoctorTypeId", "dbo.DoctorTypes", "DoctorTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "DoctorTypeId", "dbo.DoctorTypes");
            DropForeignKey("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId", "dbo.DoctorSpecializations");
            DropIndex("dbo.DoctorSpecializations", new[] { "DoctorSpecializations_DoctorSpecializationId" });
            DropIndex("dbo.Doctors", new[] { "DoctorTypeId" });
            DropColumn("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId");
        }
    }
}
