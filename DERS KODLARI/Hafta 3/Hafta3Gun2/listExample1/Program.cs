using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<long> list = new List<long>();
            //long i;
            //for ( i = 0; i < 100000; i++)
            //{
            //    list.Insert(0, i);
            // // list.Add(i); bu method daha hızlı
            //}
            //List<int> deneme = new List<int>();
            //int[] dene = new int[] { 1,2,3};
            //deneme.AddRange(dene);

            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Remove(2);
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
        }
    }
}
