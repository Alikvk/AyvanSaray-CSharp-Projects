using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public virtual Bus  Bus { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int DepartureCityId { get; set; }
        public int ArrivalCityId { get; set; }

    }
}
