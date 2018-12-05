using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] binarySearch = new int[100];
            int rastgeleSayi = rnd.Next(0, 101);
            int sayac = 0;
            string secim;
            int midPoint = 50;
            int maxPoint = 100;
            int beginPoint = 0;

            while (true)
            {
                goster();
                Console.WriteLine("Girdiğin Sayi  " + midPoint + "mi :");
                Console.WriteLine("Secim :");
                secim = Console.ReadLine();
                if (secim == "k")
                {
                    beginPoint = (maxPoint/2)- midPoint;
                    maxPoint = midPoint;
                    midPoint = (midPoint + beginPoint) / 2;

                }
                else if (secim == "b")
                {
                    maxPoint = (maxPoint) - beginPoint / 2;
                    beginPoint = midPoint;
                    midPoint = (midPoint + maxPoint) / 2;

                }
                else if (secim == "d" || secim == "D")
                {
                    Console.WriteLine(sayac + ". Adimda Buldunuz");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis Giris");
                    break;
                }
                sayac++;

               
            }
            Console.ReadKey();
        }
        public static void goster()
        {
            Console.WriteLine("k : Küçük\nb : Büyük\nd : Doğru");
        }
    }
}

