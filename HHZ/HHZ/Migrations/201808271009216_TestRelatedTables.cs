namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestRelatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        ParameterId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MinValue = c.Int(nullable: false),
                        NormalValue = c.Int(nullable: false),
                        MaxValue = c.Int(nullable: false),
                        TestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParameterId)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.ParameterValues",
                c => new
                    {
                        ParameterValuesId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        ParameterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParameterValuesId)
                .ForeignKey("dbo.Parameters", t => t.ParameterId, cascadeDelete: true)
                .Index(t => t.ParameterId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.TestId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parameters", "TestId", "dbo.Tests");
            DropForeignKey("dbo.ParameterValues", "ParameterId", "dbo.Parameters");
            DropIndex("dbo.ParameterValues", new[] { "ParameterId" });
            DropIndex("dbo.Parameters", new[] { "TestId" });
            DropTable("dbo.Tests");
            DropTable("dbo.ParameterValues");
            DropTable("dbo.Parameters");
        }
    }
}
