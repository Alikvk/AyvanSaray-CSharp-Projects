using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoryelRecursion
{
    class Program
    {
        static void Main(string[] args)
        { //Builting function string,datetime,array lerin içinde bize hazır verilen fonksiyonlardır.
            Console.WriteLine("Faktoryeli hesaplanacak sayiyi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Faktoryeli : ");
            Console.WriteLine(faktoryel(sayi));
            Console.ReadKey();

// while Döngüsü ile yapılışı
            //Console.WriteLine("Faktoryeli hesaplanacak sayiyi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int carp = 1;
            //while (sayi > 0)
            //{
            //    carp = carp * sayi;
            //    sayi--;
            //}
            //Console.Write("Faktoryeli : " + carp);
            //Console.ReadKey();

        }
        static int faktoryel(int sayi)
        {
            if (sayi == 0)
            {
                return 1;
            }
            return sayi * faktoryel(sayi - 1);
        }
    }
}
