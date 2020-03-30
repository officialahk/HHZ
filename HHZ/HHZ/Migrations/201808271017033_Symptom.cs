namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Symptom : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SymptomMedicines",
                c => new
                    {
                        SymptomMedicineId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Grade = c.Int(nullable: false),
                        Form = c.String(),
                        Formula = c.String(),
                        SymptomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SymptomMedicineId);
            
            CreateTable(
                "dbo.Symptoms",
                c => new
                    {
                        SymptomId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SymptomId);
            
            CreateTable(
                "dbo.SymptomSymptomMedicines",
                c => new
                    {
                        Symptom_SymptomId = c.Int(nullable: false),
                        SymptomMedicine_SymptomMedicineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Symptom_SymptomId, t.SymptomMedicine_SymptomMedicineId })
                .ForeignKey("dbo.Symptoms", t => t.Symptom_SymptomId, cascadeDelete: true)
                .ForeignKey("dbo.SymptomMedicines", t => t.SymptomMedicine_SymptomMedicineId, cascadeDelete: true)
                .Index(t => t.Symptom_SymptomId)
                .Index(t => t.SymptomMedicine_SymptomMedicineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SymptomSymptomMedicines", "SymptomMedicine_SymptomMedicineId", "dbo.SymptomMedicines");
            DropForeignKey("dbo.SymptomSymptomMedicines", "Symptom_SymptomId", "dbo.Symptoms");
            DropIndex("dbo.SymptomSymptomMedicines", new[] { "SymptomMedicine_SymptomMedicineId" });
            DropIndex("dbo.SymptomSymptomMedicines", new[] { "Symptom_SymptomId" });
            DropTable("dbo.SymptomSymptomMedicines");
            DropTable("dbo.Symptoms");
            DropTable("dbo.SymptomMedicines");
        }
    }
}
