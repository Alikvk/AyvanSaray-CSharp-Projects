using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public override string ToString()
        {
            return CityName; 
        }
    }
}
