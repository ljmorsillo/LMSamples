namespace HealthObservations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMeasurements : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Measurements", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
            CreateIndex("dbo.Measurements", "PatientId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Measurements", new[] { "PatientId" });
            DropForeignKey("dbo.Measurements", "PatientId", "dbo.Patients");
        }
    }
}
