using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_BomOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 -> 1-100'e kadar yazdır, 5 e bölünüyorsa BOOM
            //Thread.Sleep(500);
            //2 -> Boom sayılacak sayıyı giriniz, ona göre BOOM yaz
            //3 ->1-30'e kadar olacak Boom yine kullanıcı tarafından girilecek, bilgisayar ile karşılıklı oynanacak, kullanıcı hiç yanılmazsa berabere, 


            int iBomSayi;
            string iKullanici;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i + " Boom");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //        Thread.Sleep(500);
            //    }
            
            //}



            //Console.WriteLine("Bom Sayilacak Sayiyi Giriniz..");
            //iBomSayi = Int32.Parse(Console.ReadLine());

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % iBomSayi == 0)
            //    {
            //        Console.WriteLine(i + " Boom");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            int iAdim = 0;
            Console.WriteLine("Bom Sayilacak Sayiyi Giriniz..");
            iBomSayi = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 1)
                {

                    if (i % iBomSayi == 0)
                    {
                        Console.WriteLine("B : " + "Bom");
                    }
                    else
                    {
                        Console.WriteLine("B : " + i);
                    }
                }
                else
                {
                    Console.Write("K : ");
                    iKullanici = Console.ReadLine();
                    iAdim++;
                    if (i % iBomSayi == 0)
                    {
                        if (iKullanici == "Bom")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Oyunu Kaybettiniz " + iAdim + " adımda kaybetiniz");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        if (iKullanici == (i).ToString())
                        {

                        }
                        else
                        {
                            Console.WriteLine("Bilgisayar sayisindan bir fazla girilmesi gerekmektedir");
                            i--;
                        }

                    }
                }


            }
            Console.WriteLine("Oyun Berabere ");

            Console.ReadKey();
        }
    }
}
