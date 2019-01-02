using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimityDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor onRenk = ConsoleColor.White;
            ConsoleColor arkaRenk = ConsoleColor.DarkBlue;
            Console.BackgroundColor = arkaRenk;
            Console.ForegroundColor = onRenk;

            int x = 100;
            decimal y = 100;
            bool deger = true;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(deger);

            Console.ReadLine();
        }
    }
}
