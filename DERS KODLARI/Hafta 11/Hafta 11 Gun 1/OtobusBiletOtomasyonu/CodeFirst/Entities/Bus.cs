using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
     public class Bus
    {
        public int Id { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        public string Name { get; set; }
        public int SeatCount { get; set; }
        //public int? DriverId { get; set; }
        public override string ToString()
        {
            return Name+ " " + PlateNumber +" " + SeatCount; 
        }
    }
}
