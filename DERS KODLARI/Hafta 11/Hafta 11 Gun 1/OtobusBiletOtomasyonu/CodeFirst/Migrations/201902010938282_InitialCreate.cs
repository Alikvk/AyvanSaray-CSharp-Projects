namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlateNumber = c.String(nullable: false),
                        Name = c.String(),
                        SeatCount = c.Int(nullable: false),
                        DriverId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        IdentificationNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TripPassengerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TripId = c.Int(nullable: false),
                        PassengerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BusId = c.Int(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        ArrivalTime = c.DateTime(nullable: false),
                        DepartureCityId = c.Int(nullable: false),
                        ArrivalCityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
            DropTable("dbo.TripPassengerInfoes");
            DropTable("dbo.Passengers");
            DropTable("dbo.Cities");
            DropTable("dbo.Buses");
        }
    }
}
