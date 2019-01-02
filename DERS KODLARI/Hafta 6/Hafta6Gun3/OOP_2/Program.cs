using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan Mert = new Insan();
            Kopek Lessi = new Kopek();
            Mert.el = 2;
            Mert.ayak = 2;
            Lessi.ayak = 4;

            Mert.Konus();
            Lessi.Havla();
        }
    }
}
