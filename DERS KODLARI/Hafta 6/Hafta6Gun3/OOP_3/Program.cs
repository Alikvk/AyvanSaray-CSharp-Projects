using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Canli.Konus(CanliTipi.Insan,"ben bir insanım");
            Canli.Konus(CanliTipi.Hayvan, Hareket.PatiUzat);
            Canli.Konus("Hav");
            Console.ReadLine();

        }
    }
}
