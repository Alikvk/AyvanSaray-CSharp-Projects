﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 49 arasında rasgele 6 sayıyı bir diziye aktaran bunları kendi arasında sıralayan programı yazınız


            //For ile yapılan kısmında bir sıkıntı yok while ile yaparken bir iki eksiği var
            int ilkSayi;
            int ikinciSayi;
            int[] fibonacciSayilar = new int[100];

            Console.WriteLine("İlk fibonacci sayisini giriniz");
            ilkSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İlk fibonacci sayisini giriniz");
            ikinciSayi = Convert.ToInt32(Console.ReadLine());


            int toplam = 0;
            int sayac = 2;
            fibonacciSayilar[0] = ilkSayi;
            fibonacciSayilar[1] = ikinciSayi;

            for (int i = 2; i < 100; i++)
            {

                if (ilkSayi + ikinciSayi > 100)
                {
                    break;
                }
                else
                {
                    fibonacciSayilar[i] = ilkSayi + ikinciSayi;
                    ilkSayi = ikinciSayi;
                    ikinciSayi = fibonacciSayilar[i];
                }


            }
            foreach (int sayi in fibonacciSayilar)
            {
                Console.Write(sayi + " ");
            }
            //while (toplam < 100)
            //{

            //    if (toplam > 100)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        toplam = ilkSayi + ikinciSayi;
            //        fibonacciSayilar[sayac] = toplam;
            //        sayac++;
            //        ilkSayi = ikinciSayi;
            //        ikinciSayi = toplam;

            //    }

            //}
            //foreach (int sayi in fibonacciSayilar)
            //{
            //    Console.Write(sayi + " ");
            //}
            Console.ReadKey();
            //---------------------------------------------------------------------------------------------------------------------------------
            //implicit conversion (type-safe'tir.veri kaybı olmaz)
            //int sayi = 5000;
            //long dahabuyuksayi = sayi;

            ////expilicit conversion (veri kaybı vardır)
            //double ondaliklisayi = 154.95;
            //int tamsayi = (int)ondaliklisayi;

            ////aşağıdaki cast işlemi hata verir
            //string yazi = "24121";
            //int sonuc = (int)yazi;

            ////aşağıdaki cast'ten byte'a değer olarak 192 gelir. 56000%256
            //int numara = 56000;
            //byte kucukSayi = (byte)numara;

        }
    }
}
