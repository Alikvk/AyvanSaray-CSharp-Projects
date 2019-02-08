using CodeFirst.Entities;
using System;
using System.Data.Entity;
using System.Linq;
namespace CodeFirst
{
 

    public class BusModel : DbContext
    {

        public BusModel()
            : base("name=BusModel")
        {

        }
        
         public virtual DbSet<City> Cities { get; set; }
         public virtual DbSet<Trip> Trips { get; set; }
         public virtual DbSet<TripPassengerInfo> TripPassengerInfos { get; set; }
         public virtual DbSet<Passenger> Passengers { get; set; }
         public virtual DbSet<Bus> Buses { get; set; }
    }


}