namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDoctor1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId", "dbo.DoctorSpecializations");
            DropIndex("dbo.DoctorSpecializations", new[] { "DoctorSpecializations_DoctorSpecializationId" });
            AddColumn("dbo.DoctorSpecializations", "Specializations_SpecializationId", c => c.Byte());
            CreateIndex("dbo.DoctorSpecializations", "Specializations_SpecializationId");
            AddForeignKey("dbo.DoctorSpecializations", "Specializations_SpecializationId", "dbo.Specializations", "SpecializationId");
            DropColumn("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId", c => c.Byte());
            DropForeignKey("dbo.DoctorSpecializations", "Specializations_SpecializationId", "dbo.Specializations");
            DropIndex("dbo.DoctorSpecializations", new[] { "Specializations_SpecializationId" });
            DropColumn("dbo.DoctorSpecializations", "Specializations_SpecializationId");
            CreateIndex("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId");
            AddForeignKey("dbo.DoctorSpecializations", "DoctorSpecializations_DoctorSpecializationId", "dbo.DoctorSpecializations", "DoctorSpecializationId");
        }
    }
}
