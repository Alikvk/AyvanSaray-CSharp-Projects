using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaYollari
{
    class Program
    {
        
        public static int koltuksecimi, i;
        public static string[] economy = { "", "", "", "", "", "", "", "", "", "", "", "" };
        public static string[] business = { "", "", "", "", "", "", "", "" };
        public static string tus, isim;
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            try
            {
                anamenu();
                isimal();
                koltukkontrol();
                rezervasyon();
                Main(null);
            }
            catch (Exception)
            {
                Console.WriteLine("İstenmedik Bir Hata ile karşılaştınız lütfen yetkili bir kişi ile geçiniz..");
                Main(null);
            }
        }
        public static void anamenu()
        {
            Console.WriteLine("1. Business Class bölümü için 1 tuşuna basınız");
            Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basınız");
            tus = Console.ReadLine();
            switch (tus)
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir karakter giriniz");
                    anamenu();
                    break;
            }
        }
        public static void koltukkontrol()
        {
            int sayac = 0;
            if (tus == "1")
            {
                for (int i = 0; i < business.Length; i++)
                {
                    if (business[i] == "")
                    {
                        Console.WriteLine("{0}. koltuk boş", i);
                    }
                    else
                    {
                        sayac++;
                        Console.WriteLine("{0}. Koltk Dolu", i);
                    }
                }
                if (sayac == business.Length)
                {
                    Console.WriteLine("Bu salonumuz dolmuştur");
                }
                else if (sayac != business.Length)
                {
                    Console.WriteLine("Bu salonumuzda yerimiz mevcuttur.");
                }
            }
            else if (tus == "2")
            {
                for (int i = 0; i < economy.Length; i++)
                {

                    if (economy[i] == "")
                    {
                        Console.WriteLine("{0}. koltuk boş", i);
                    }
                    else
                    {
                        sayac++;
                        Console.WriteLine("{0}. Koltk Dolu", i);
                    }
                }
                if (sayac == economy.Length)
                {
                    Console.WriteLine("Bu salonumuz dolmuştur");
                }
                else if (sayac != economy.Length)
                {
                    Console.WriteLine("Bu salonumuzda yerimiz mevcuttur.");
                }
            }

        }
        public static void isimal()
        {
            Console.WriteLine("Lütfen Adinizi Giriniz..");
            isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++)
            {
                if (char.IsDigit(isim[i]) == true)
                {
                    Console.WriteLine("Lütfen sayısal bir değer girmeyiniz..");
                    isimal();
                }
            }
        }
        public static void rezervasyon()
        {
            if (tus == "1")
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltuksecimi = Convert.ToInt32(Console.ReadLine());
                rezervasyonkontrol();
                Console.WriteLine("{0}. koltuk {1} rezerve edilmiştir.", koltuksecimi, business[koltuksecimi]);
                koltukkontrol();
            }
            else if (tus == "2")
            {
                Console.WriteLine("İstediğiniz koltuğu seçiniz");
                koltuksecimi = Convert.ToInt32(Console.ReadLine());
                rezervasyonkontrol();
                Console.WriteLine("{0}. koltuk {1} rezerve edilmiştir.", koltuksecimi, economy[koltuksecimi]);
                koltukkontrol();
            }

        }
        public static void rezervasyonkontrol()
        {
            try
            {
                if (tus == "1")
                {
                    if (business[koltuksecimi] == "")
                    {
                        business[koltuksecimi] = isim;
                    }
                    else
                    {
                        Console.WriteLine("{0} numaralı koltuğu daha önce {1} isimli yolcuya rezerve ettiniz! Lütfen boş koltuklardan biriniz seçiniz.", koltuksecimi, business[koltuksecimi]);
                        rezervasyon();
                    }
                }
                else if (tus == "1")
                {
                    if (economy[koltuksecimi] == "")
                    {
                        economy[koltuksecimi] = isim;
                    }
                    else
                    {
                        Console.WriteLine("{0} numaralı koltuğu daha önce {1} isimli yolcuya rezerve ettiniz! Lütfen boş koltuklardan biriniz seçiniz.", koltuksecimi, economy[koltuksecimi]);
                        rezervasyon();
                    }
                }

            }
            catch (Exception)
            {

                Console.WriteLine("İstenmeyen bir durum oluştu yönlendiriliyorsunuz...");
                rezervasyon();
            }
        }

    }
}
