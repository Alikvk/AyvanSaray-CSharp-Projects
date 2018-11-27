using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1_CinFali
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


            //-------------------------------------------------------------------------------------------

            //Fal baktırmak isim, doğum tarih ilk -> 
            //1. aşama -> isim ve doğum tarihi(DateTime) girerken girilen ismin rakam içermediğinden ve tarihin geçerli bir formatta yazıldığından emin olun. (Kullanıcıyı tekrar giriş yaptır.) Ayrıca fal baktıracak kişi > 18, değilse programı sonlandır.
            //2. aşama -> çin burcu, tarihi çin burcunda kontrol et, burcunu ekrana yaz
            //1960 fare, 61 öküz ,62 kaplan, 63 tavşan, 64 ejderha, 65 yılan, 66 at, 67 keçi, 68 maymun, 69 horoz, 70 köpek, 71 domuz (mod 12)
            //3. aşama -> kişinin bir sonraki doğum gününün haftanın hangi günü olduğunu yaz.

            //-------------------------------------------------------------------------------------------

            string sName;
            string sBirthDate = "";
            DateTime dtBirthDate;
            int iMod;

            Console.WriteLine("Adinizi Giriniz..");
            sName = Console.ReadLine();

            //Girilen isim sadece harflerden oluşmalı
            while (!sName.All(Char.IsLetter))
            {
                Console.WriteLine("İsminiz sadece harflerden oluşabilir");
                sName = Console.ReadLine();
            }

            //Doğum tarihi kontrolü yapılmakta
            while (!DateTime.TryParse(sBirthDate, out dtBirthDate))
            {//tryParse bir nevi try catch bloğu şeklinde çalışmakta 

                Console.WriteLine("Dogum Tarihi Giriniz..(dd/mm/yyyy seklinde)");
                sBirthDate = Console.ReadLine();


            }
            if (DateTime.Now.Year - dtBirthDate.Year < 18)
            {
                Console.WriteLine("18 Yaşından küçük olduğunuz için fal baktıramazsınız..");
                Console.ReadKey();
                Environment.Exit(0);
            }
            // 12 çin burcu hayvanı hangi yılda olduğunu bulmak için girilen tarihin 12'ye modunu almaktayız 
            iMod = dtBirthDate.Year % 12;

            switch (iMod)
            {
                case 0:
                    Console.WriteLine("Çin Burcunuz Maymun");
                    break;
                case 1:
                    Console.WriteLine("Çin Burcunuz Horoz");
                    break;
                case 2:
                    Console.WriteLine("Çin Burcunuz Köpek");
                    break;
                case 3:
                    Console.WriteLine("Çin Burcunuz Domuz");
                    break;
                case 4:
                    Console.WriteLine("Çin Burcunuz Fare");
                    break;
                case 5:
                    Console.WriteLine("Çin Burcunuz Öküz");
                    break;
                case 6:
                    Console.WriteLine("Çin Burcunuz Kaplan");
                    break;
                case 7:
                    Console.WriteLine("Çin Burcunuz Tavşan");
                    break;
                case 8:
                    Console.WriteLine("Çin Burcunuz Ejderha");
                    break;
                case 9:
                    Console.WriteLine("Çin Burcunuz Yılan");
                    break;
                case 10:
                    Console.WriteLine("Çin Burcunuz At");
                    break;
                case 11:
                    Console.WriteLine("Çin Burcunuz Keçi");
                    break;

                default:
                    break;
            }

            Console.WriteLine("Doğduğunuz gün " + dtBirthDate.ToString("F"));

            dtBirthDate = dtBirthDate.AddDays(365);

            Console.WriteLine("Bir sonraki doğum gününüz " + dtBirthDate.ToString("F"));

            Console.ReadKey();
        }
    }
}
