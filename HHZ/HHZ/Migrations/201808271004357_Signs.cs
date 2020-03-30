namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Signs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Signs",
                c => new
                    {
                        SignId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SignId);
            
            CreateTable(
                "dbo.SignsValues",
                c => new
                    {
                        SignsValueId = c.Int(nullable: false, identity: true),
                        ValueName = c.String(),
                        SignId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SignsValueId)
                .ForeignKey("dbo.Signs", t => t.SignId, cascadeDelete: true)
                .Index(t => t.SignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SignsValues", "SignId", "dbo.Signs");
            DropIndex("dbo.SignsValues", new[] { "SignId" });
            DropTable("dbo.SignsValues");
            DropTable("dbo.Signs");
        }
    }
}
