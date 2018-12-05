using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case sensitivity   Büyük küçük duyarlı
            //Context sensitivity İ:çeriğe bağlı bir yapı değişikliği için farklılaşması örneğin yazı sağ tıkladığımızda seçtiğimiz menü ile resme sağ tıklayıp seçtiğimiz menü farklı olması
            // Veri Tipleri arasında dönüşüm yapma 
            //implicit conversion(kapalı dönüşüm) : Eğer bir veri tipi kendisinde büyük bir değere aktarmasına denir.
            //explicit conversion(açık dönüşüm)   : Eğer bir veri tipi kendisinde küük bir değere aktarmasına denir.Veri kaybı olur . 
            // byte toplam;
            //int sayi=25;
            // toplam=(byte)sayi burada sayi önüne "cast" olarak tanımladığımız değeri ilk çevireceğimiz veri tipine çevirip atıyoruz.
            // redundant: Gereksiz kod kullanma visual studio da altını yeşil çizer
            //  Convert conversion : Convert keywordu kullanılır.
            // İnstance : Ramde bulunan bir objedir. nesne tanımlarken örn: int[] a= new int[2] a burada instance olarak bulunur  
//--------------------------------------------------------------------------------------
            //try
            //{
            //    int a = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine(3 / a);

            //}

            //catch (DivideByZeroException nesne)
            //{
            //    Console.WriteLine("Sifira Bölünemez");
            //}
            //catch (Exception nesne)
            //{
            //    Console.WriteLine("Hata var");

            //}
            //Console.ReadKey();
            //--------------------------------------------------------------------------------------
            // int iAy;

            //Console.WriteLine("Kaçıncı Aydayiz Giriniz");
            //iAy = Int32.Parse(Console.ReadLine());

            //switch (iAy)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış Mevsimi");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar Mevsimi");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz Mevsimi");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar Mevsimi");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış Değer Girdiniz");
            //        break;
            //}

            //Console.ReadKey();
//--------------------------------------------------------------------------------------

            //   int iAy = 0;

            //Console.WriteLine("Kaçıncı Aydayiz Giriniz");
            //try
            //{
            //    iAy = Int32.Parse(Console.ReadLine());

            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("Girdiğiniz değer sayisal olmalı");
            //    Console.ReadKey();

            //    Environment.Exit(0);
            //}

            //switch (iAy)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış Mevsimi");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar Mevsimi");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yaz Mevsimi");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Sonbahar Mevsimi");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış Değer Girdiniz");
            //        break;
            //}

            //if (iAy == 12)
            //{
            //    iAy = 0;
            //}
            //switch (iAy)
            //{
            //    case int iRange when (iRange >= 3 && iRange <= 5):
            //        Console.WriteLine("İlkbahar Mevsimi");
            //        break;
            //    case int iRange when (iRange >= 6 && iRange <= 8):
            //        Console.WriteLine("Yaz Mevsimi");
            //        break;
            //    case int iRange when (iRange >= 9 && iRange <= 11):
            //        Console.WriteLine("Sonbahar Mevsimi");
            //        break;
            //    case int iRange when (iRange >= 0 && iRange <= 2):
            //        Console.WriteLine("Kış Mevsimi");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış değer girdiniz..");
            //        break;
            //}
            //Console.ReadKey();
//--------------------------------------------------------------------------------------



        }
    }
}
