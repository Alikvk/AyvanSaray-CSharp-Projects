using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTypeExample
{
    class Program
    {
        //enum Seasons
        //{
        //    Winter,
        //    Summer,
        //    Autumn,
        //    Sprimg

        //}
        // İndexi istediğimiz sayıdan başlatabiliriz.
        enum Seasons
        {
            Winter=12,
            Summer,
            Autumn,
            Sprimg

        }
        static void Main(string[] args)
        {
            // Seasons autumnS = Seasons.Autumn;
            string[] mevsimler = new string[4];
            mevsimler = Enum.GetNames(typeof(Seasons));// Elemanları bir diziye aktarıyoruz
            foreach (var s in mevsimler)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine((int)Seasons.Winter);
            Console.WriteLine((int)Seasons.Sprimg);
            Console.ReadKey();
        }
    }
}
