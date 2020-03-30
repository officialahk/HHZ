namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorComplete : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClinicInfoes",
                c => new
                    {
                        ClinicInfoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Contact = c.String(),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClinicInfoId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.ClinicTimes",
                c => new
                    {
                        ClinicTimeId = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                        StartTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        EndTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Status = c.Boolean(nullable: false),
                        ClinicInfoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClinicTimeId)
                .ForeignKey("dbo.ClinicInfoes", t => t.ClinicInfoId, cascadeDelete: true)
                .Index(t => t.ClinicInfoId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        ProfessionalStatement = c.String(),
                        Biography = c.String(),
                        ContactNumber = c.String(),
                        PostalAddress = c.String(),
                        Cnic = c.Int(nullable: false),
                        MaterialStatus = c.Boolean(nullable: false),
                        SpouseName = c.String(),
                        ImageUrl = c.String(),
                        Facebook = c.String(),
                        Twitter = c.String(),
                        Linkedin = c.String(),
                        Rss = c.String(),
                        GooglePlus = c.String(),
                        Youtube = c.String(),
                        Website = c.String(),
                        DoctorExperienceId = c.Int(nullable: false),
                        DoctorTypeId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DoctorId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.DoctorExperiences",
                c => new
                    {
                        DoctorExperienceId = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        StartingDate = c.Int(nullable: false),
                        EndingDate = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorExperienceId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.DoctorQualifications",
                c => new
                    {
                        DoctorQualificationId = c.Byte(nullable: false),
                        QualificationName = c.String(nullable: false),
                        InstituteName = c.String(nullable: false),
                        StartingDate = c.Int(nullable: false),
                        EndingDate = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorQualificationId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.DoctorSpecializations",
                c => new
                    {
                        DoctorSpecializationId = c.Byte(nullable: false),
                        InstituteName = c.String(nullable: false),
                        StartingDate = c.Int(nullable: false),
                        EndingDate = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                        SpecializationId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorSpecializationId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.DoctorTypes",
                c => new
                    {
                        DoctorTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DoctorTypeId);
            
            CreateTable(
                "dbo.Specializations",
                c => new
                    {
                        SpecializationId = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SpecializationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClinicInfoes", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.DoctorSpecializations", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.DoctorQualifications", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.DoctorExperiences", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.ClinicTimes", "ClinicInfoId", "dbo.ClinicInfoes");
            DropIndex("dbo.DoctorSpecializations", new[] { "DoctorId" });
            DropIndex("dbo.DoctorQualifications", new[] { "DoctorId" });
            DropIndex("dbo.DoctorExperiences", new[] { "DoctorId" });
            DropIndex("dbo.Doctors", new[] { "UserId" });
            DropIndex("dbo.ClinicTimes", new[] { "ClinicInfoId" });
            DropIndex("dbo.ClinicInfoes", new[] { "DoctorId" });
            DropTable("dbo.Specializations");
            DropTable("dbo.DoctorTypes");
            DropTable("dbo.DoctorSpecializations");
            DropTable("dbo.DoctorQualifications");
            DropTable("dbo.DoctorExperiences");
            DropTable("dbo.Doctors");
            DropTable("dbo.ClinicTimes");
            DropTable("dbo.ClinicInfoes");
        }
    }
}
