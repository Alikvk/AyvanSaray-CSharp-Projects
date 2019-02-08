namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DriverDeletedFromBus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Buses", "DriverId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buses", "DriverId", c => c.Int());
        }
    }
}
