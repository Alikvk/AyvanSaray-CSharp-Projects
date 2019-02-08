namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TripBusKeyAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "BusId_Id", c => c.Int());
            CreateIndex("dbo.Trips", "BusId_Id");
            AddForeignKey("dbo.Trips", "BusId_Id", "dbo.Buses", "Id");
            DropColumn("dbo.Trips", "BusId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "BusId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Trips", "BusId_Id", "dbo.Buses");
            DropIndex("dbo.Trips", new[] { "BusId_Id" });
            DropColumn("dbo.Trips", "BusId_Id");
        }
    }
}
