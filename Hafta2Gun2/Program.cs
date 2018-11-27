using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun2
{
    class Program
    {
        static void Main(string[] args)
        {


//--------------------------------------------------------------------------------
            // Clone'nun return type object olduğundan clone yapınca casti belirlememiz gerekmektedir
            // yenigunler = (string[])gunler.Clone();

            //string[] gunler = new string[7];
            //string[] yeniGunlerClone = new string[7];
            //string[] yeniGunlerCopy = new string[7];

            //gunler[0] = "Pazertesi";
            //gunler[1] = "Salı";
            //gunler[2] = "Çarşamba";
            //gunler[3] = "Perşembe";
            //gunler[4] = "Cuma";
            //gunler[5] = "Cumartesi";
            //gunler[6] = "Pazar";
            ////Array.Clear(gunler, 0, 3);

            //yeniGunlerClone = (string[])gunler.Clone(); // Clone işlemi
            //Array.Copy(gunler, yeniGunlerCopy, 7);      // Copy işlemi

            //gunler[4] = "Friday"; // Değişiklik olup olmadığını görmek için değişkeni değiştiriyoruz

            //Console.WriteLine("Gunler Dizisi\n");

            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Clone\n");
            //for (int i = 0; i < yeniGunlerClone.Length; i++)
            //{
            //    Console.WriteLine(yeniGunlerClone[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Copy\n");
            //for (int i = 0; i < yeniGunlerCopy.Length; i++)
            //{
            //    Console.WriteLine(yeniGunlerCopy[i]);
            //}

            //gunler[4] = "Cuma";
            //Array.Sort(gunler);                         // Sort işlemi

            //Console.WriteLine();
            //Console.WriteLine("Sort\n");
            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}
            //Array.Reverse(gunler);                      // Reverse İşlemi

            //Console.WriteLine();
            //Console.WriteLine("Reverse\n");
            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}

            //Console.ReadKey();
 //--------------------------------------------------------------------------------
            //char secim = 'a';



            //while (!(secim == 'q'))
            //{
            //    int sayiAdedi = 0;
            //    int toplamSayi = 0;
            //    bool control = true;



            //    //Console.Write("Kaç Adet Sayi Gireceksiniz : ");
            //    //sayiAdet = Console.ReadLine();

            //    //while (!sayiAdet.All(Char.IsDigit))
            //    //{
            //    //    Console.Write("Kendine Gel Sayi olmali : ");
            //    //    sayiAdet = Console.ReadLine();

            //    //}


            //    control = true;
            //    while (control)
            //    {
            //        Console.Write("Kaç Adet Sayi Gireceksiniz : ");

            //        try
            //        {

            //            sayiAdedi = Convert.ToInt32(Console.ReadLine());

            //            control = false;
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Sayi Girmezsen olmazz. ");
            //            control = true;
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("Sayi Çok Büyük Az olsun :");
            //            control = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Hata var : " + ex.Message);
            //        }
            //        if (sayiAdedi < 0)
            //        {
            //            Console.WriteLine("Sayi Adedi 0 dan küçük olamaz");
            //            control = true;
            //        }
            //        else
            //        {
            //            control = false;
            //        }
            //    }



            //    int[] sayilar = new int[sayiAdedi];

            //    for (int i = 0; i < sayiAdedi; i++)
            //    {
            //        bool kontrol = true;

            //        while (kontrol)
            //        {
            //            Console.Write(i + 1 + ". Sayiyi Giriniz : ");
            //            try
            //            {
            //                sayilar[i] = Int32.Parse(Console.ReadLine());
            //                kontrol = false;

            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Sayi olmazsa Toplamam..  ");
            //                kontrol = true;

            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("Farklı bir hata var");
            //            }
            //        }

            //        toplamSayi = toplamSayi + sayilar[i];
            //    }

            //    Console.WriteLine("Al Bakalım sayiların Toplami");

            //    for (int i = 0; i < sayiAdedi; i++)
            //    {
            //        if (i == sayiAdedi - 1)
            //        {
            //            Console.Write(sayilar[i] + "=");

            //        }
            //        else
            //        {
            //            Console.Write(sayilar[i] + "+");

            //        }
            //    }

            //    Console.Write(toplamSayi);
            //    Console.WriteLine();
            //    Console.Write("Cikmak icin 'q' ya basiniz \nDevam Etmek için Herhangi bir karateri yazip enterlayın  : ");
            //    secim = Convert.ToChar(Console.ReadLine());
            //    if (secim == 'q')
            //    {
            //        Environment.Exit(0);
            //    }

            //}

            //Console.ReadKey();
            //--------------------------------------------------------------------------------------------
            //bool outControl = true;
            //do
            //{
            //    Random rnd = new Random();
            //    int randomNumber = rnd.Next(1, 11);
            //    int guessNumber = 0;
            //    int stepNo = 0;
            //    char c;
            //    bool control = true;
            //    Console.WriteLine("Bilgisayar Tahmini " + randomNumber);
            //    while (control)
            //    {

            //        try
            //        {
            //            Console.Write("Sayiyi Giriniz :");
            //            guessNumber = Int32.Parse(Console.ReadLine());
            //            stepNo++;
            //            control = false;
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Yanlış Değer Girdiniz");
            //            control = true;
            //        }
            //        catch (OverflowException)
            //        {
            //            Console.WriteLine("Sayi değeri çok fazla");
            //            control = true;

            //        }
            //        if (guessNumber == 0)
            //        {
            //            Environment.Exit(0);
            //        }
            //        else if (guessNumber < 0)
            //        {
            //            Console.WriteLine("Girdiğiniz Değer 0 dan küçük olamaz");
            //            control = true;
            //        }
            //        else if (guessNumber > 10)
            //        {
            //            Console.WriteLine("Girdiğiniz Değer 0 dan büyük olamaz");
            //            control = true;

            //        }
            //        else if (randomNumber == guessNumber)
            //        {
            //            Console.WriteLine(stepNo + ". Adimda Bildiniz");
            //            control = false;
            //        }
            //        else
            //        {
            //            control = true;
            //        }
            //    }
            //    do
            //    {
            //        Console.WriteLine("Devam Etmek İçin E/H Basiniz");
            //        c = Convert.ToChar(Console.ReadLine());
            //        if (c == 'e' || c == 'E')
            //        {
            //            outControl = true;
            //        }
            //        else if (c == 'h' || c == 'H')
            //        {
            //            outControl = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Farklı Değer Girilemez");
            //            outControl = true;
            //        }
            //    } while (outControl);

            //} while (outControl);
            //--------------------------------------------------------------------------------------------

        }
    }
}
