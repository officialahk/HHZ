namespace HHZ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDoctorTypes : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO DoctorTypes (NAME) VALUES ('Homeopath')");
            Sql("INSERT INTO DoctorTypes (NAME) VALUES ('Ayurveda')");
            Sql("INSERT INTO DoctorTypes (NAME) VALUES ('Allopathic')");
            Sql("INSERT INTO DoctorTypes (NAME) VALUES ('Osteopathic')");
           
        }
        
        public override void Down()
        {
            Sql("DELETE FROM DoctorTypes WHERE VALUES IN (Homeopath,Ayurveda,Allopathic,Osteopathic)");

        }
    }
}
