namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BusIdNameChangeBus : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Trips", name: "BusId_Id", newName: "Bus_Id");
            RenameIndex(table: "dbo.Trips", name: "IX_BusId_Id", newName: "IX_Bus_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Trips", name: "IX_Bus_Id", newName: "IX_BusId_Id");
            RenameColumn(table: "dbo.Trips", name: "Bus_Id", newName: "BusId_Id");
        }
    }
}
