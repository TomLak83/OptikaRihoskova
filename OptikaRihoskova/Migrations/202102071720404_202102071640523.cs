namespace OptikaRihoskova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _202102071640523 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Appointment");
            AlterColumn("dbo.Appointment", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Appointment", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Appointment");
            AlterColumn("dbo.Appointment", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Appointment", "Id");
        }
    }
}
