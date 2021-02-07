namespace OptikaRihoskova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ClientEmail = c.String(),
                        Optometrist = c.String(),
                        StartDateTime = c.DateTime(nullable: false),
                        DurationMins = c.Int(nullable: false),
                        OptometristConfiremed = c.Boolean(nullable: false),
                        ClientConfirmed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appointment");
        }
    }
}
