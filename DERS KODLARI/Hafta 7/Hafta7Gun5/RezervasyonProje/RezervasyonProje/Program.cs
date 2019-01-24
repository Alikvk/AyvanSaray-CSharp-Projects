using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonProje
{
    class Program
    {
        abstract public class Rezervasyon
        {

            protected const int odaSayisi = 10;
            protected const int gunSayisi = 30;
            protected enum RezervasyonEnum
            {
                Bos,
                Dolu,
                Temizlik
            }

            protected RezervasyonEnum[,] rezervasyonDurumu = new RezervasyonEnum[odaSayisi, gunSayisi];

            public Rezervasyon()
            {
            }
            public Rezervasyon(DateTime baslangic, DateTime bitis)
            {

            }
            public Rezervasyon(DateTime baslangic, int kalinacakGun)
            {

            }

            public abstract string KiralananYerTipi();
            public abstract string UygulamaAdi();
            public abstract bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi();
            public abstract int Fiyat(int gunSayisi, bool cift);
            protected virtual bool ErtesiGunTemizlikIcinBosBirakilacakMi()
            {
                return true;
            }

            public void BugunkuBosOdalar()
            {
                bool bosOdaYok = true;
                for (int i = 0; i < odaSayisi; i++)
                {
                    if (rezervasyonDurumu[i, 0] == RezervasyonEnum.Bos
                        && rezervasyonDurumu[i, 1] == RezervasyonEnum.Bos)
                    {
                        bosOdaYok = false;
                        Console.WriteLine(i + 1);
                    }
                }
                if (bosOdaYok)
                    Console.WriteLine("Bugun icin bos " + KiralananYerTipi() + " yok");
            }
            public void RasgeleDoldur()
            {
                rezervasyonDurumu[0, 0] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[0, 1] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[0, 5] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[0, 6] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[1, 7] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[1, 8] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[2, 9] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[2, 10] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[5, 15] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[5, 16] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[8, 20] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[8, 21] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[0, 27] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[0, 28] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[9, 29] = RezervasyonEnum.Dolu;

                rezervasyonDurumu[4, 0] = RezervasyonEnum.Temizlik;
                rezervasyonDurumu[5, 1] = RezervasyonEnum.Dolu;
                rezervasyonDurumu[5, 2] = RezervasyonEnum.Temizlik;
            }
            public virtual void AylikDolulukDurumu()
            {
                Console.Write("      ");
                TarihCetveliniYazdir();
                Console.WriteLine();
                for (int i = 0; i < odaSayisi; i++)
                {
                    Console.Write("" + KiralananYerTipi() + " {0:00}", i + 1);
                    for (int j = 0; j < gunSayisi; j++)
                    {
                        if (rezervasyonDurumu[i, j] == RezervasyonEnum.Bos)
                            Console.Write(" - ");
                        else if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                            Console.Write(" D ");
                        else
                            Console.Write(" x ");
                    }
                    Console.WriteLine();
                }
            }
            public void RezervasyonYap(bool yanYanaIkiRezervasyon = false)
            {
                RezervasyonYap(DateTime.Today, DateTime.Today, yanYanaIkiRezervasyon);
            }
            // baslangic tarihinden itibaren verilen gun sayisi kadar rezervasyon yapar
            public void RezervasyonYap(DateTime basTarihi, int gun, bool yanYanaIkiRezervasyon = false)
            {
                RezervasyonYap(basTarihi, basTarihi.AddDays(gun-1), yanYanaIkiRezervasyon);
            }
            // verilen iki tarih arasinda rezervasyon yapar
            public void RezervasyonYap(DateTime date1, DateTime date2, bool yanYanaIkiRezervasyon = false)
            {
                if (yanYanaIkiRezervasyon == true && YanYanaIkiYerBirdenRezervasyonYapilabilirMi() == false)
                {
                    Console.WriteLine("Ayni rezervasyonda yan yana iki yer ayrilmasina izin verilmiyor");
                    return;
                }
                if (date1 < DateTime.Today)
                {
                    Console.WriteLine("Baslangic tarihi bugunden kucuk olamaz");
                    return;
                }
                if (date2 < date1)
                {
                    Console.WriteLine("Bitis tarihi baslangic tarihinden kucuk olamaz");
                    return;
                }
                if ((date1 - DateTime.Today).Days >= gunSayisi)
                {
                    Console.WriteLine("Baslangic tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi - 1));
                    return;
                }
                if ((date2 - DateTime.Today).Days >= gunSayisi)
                {
                    Console.WriteLine("Bitis tarihi {0:dd/MM/yyyy} tarihinden buyuk olamaz", DateTime.Today.AddDays(gunSayisi - 1));
                    return;
                }
                int gun1 = (date1 - DateTime.Today).Days;
                int gun2 = (date2 - DateTime.Today).Days;
                bool bosOdaYok = true;
                for (int i = 0; i < odaSayisi; i++)
                {
                    // yerleri ikiser ikiser kontrol ederken, hep bir sonraki yere de bak.
                    // son yerden bir onceki yere kadar devam et.
                    if (yanYanaIkiRezervasyon && i == (odaSayisi - 1))
                        break;

                    bool odaMusait = true;
               
                    for (int k = 0; k <= (yanYanaIkiRezervasyon ? 1 : 0); k++)
                    {
                        for (int j = gun1; j <= gun2; j++)
                        {
                            if (rezervasyonDurumu[i + k, j] != RezervasyonEnum.Bos)
                            {
                                odaMusait = false;
                                break;
                            }
                        }
                       
                        if (ErtesiGunTemizlikIcinBosBirakilacakMi())
                        {
                            if (gun2 < (gunSayisi - 1))
                            {
                                if (rezervasyonDurumu[i + k, gun2 + 1] != RezervasyonEnum.Bos)
                                    odaMusait = false;
                            }
                        }
                    }
                    if (odaMusait)
                    {
                        bosOdaYok = false;
                        for (int j = gun1; j <= gun2; j++)
                        {
                            for (int k = 0; k <= (yanYanaIkiRezervasyon ? 1 : 0); k++) // sonraki yeri de rezerve et.
                                rezervasyonDurumu[i + k, j] = RezervasyonEnum.Dolu;
                        }
                     
                        if (ErtesiGunTemizlikIcinBosBirakilacakMi())
                        {
                            if (gun2 < (gunSayisi - 1))
                            {
                                for (int k = 0; k <= (yanYanaIkiRezervasyon ? 1 : 0); k++) // sonraki yeri de rezerve et.
                                    rezervasyonDurumu[i + k, gun2 + 1] = RezervasyonEnum.Temizlik;
                            }
                        }
                        Console.WriteLine("{0} "
                            + (yanYanaIkiRezervasyon ? "ve {1} " : "")
                            + "numarali " + KiralananYerTipi().ToLower() + " sizin icin ayrildi", i + 1, i + 2);
                       
                        Console.WriteLine("Toplam fiyat : {1} TL, {0} gun.",
                            (date2 - date1).Days + 1,this.Fiyat((date2 - date1).Days + 1, yanYanaIkiRezervasyon));
                        break;
                    }
                }
                if (bosOdaYok)
                    Console.WriteLine("Istediginiz tarihte bos " + KiralananYerTipi().ToLower() + " yok");
            }
            public void OtelVeYatRezervasyonYap()
            {

            }
            public void GunBazindaDolulukOranlari()
            {
                Console.Write(" -------- ");
                TarihCetveliniYazdir();
                
                Console.Write("\nDoluluk % ");
                int doluOdaSayisi = 0;

                for (int j = 0; j < gunSayisi; j++)
                {
                    doluOdaSayisi = 0;
                    for (int i = 0; i < odaSayisi; i++)
                    {
                        if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                        {
                            doluOdaSayisi++;
                        }
                    }
                    Console.Write("{0,3}", (int)(100f * doluOdaSayisi / odaSayisi));
                }
                Console.WriteLine();
            }
            public void GunSonuIslemi()
            {
                for (int i = 0; i < odaSayisi; i++)
                {
                    for (int j = 0; j < gunSayisi - 1; j++)
                    {
                        rezervasyonDurumu[i, j] = rezervasyonDurumu[i, j + 1];
                    }
                    if (rezervasyonDurumu[i, gunSayisi - 2] == RezervasyonEnum.Dolu)
                        rezervasyonDurumu[i, gunSayisi - 1] = RezervasyonEnum.Temizlik;
                    else
                        rezervasyonDurumu[i, gunSayisi - 1] = RezervasyonEnum.Bos;
                }
            }
            public static void TarihCetveliniYazdir()
            {
                for (int j = 0; j < gunSayisi; j++)
                {
                    Console.Write(" {0:00}", DateTime.Today.AddDays(j).Day);
                }
            }



        }
        class OtelRezervasyon : Rezervasyon
        {

            public override int Fiyat(int gunSayisi, bool ciftYer)
            {
                return gunSayisi > 5 ? 90 : 100; // Eğer gün sayisi 5 ten büyük ise 90 değillse 100 lira ödesin
            }

            public override string KiralananYerTipi()
            {
                return "Otel";

            }

            public override string UygulamaAdi()
            {
                return "Otel";
            }

            public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
            {
                return false;
            }

        }
        class CadirRezervasyon : Rezervasyon
        {
            public override int Fiyat(int gunSayisi, bool ciftYer)
            {
                // kucuk cadir icin tek yer gunluk 100 TL. 
                // buyuk cadir icin cift yer gunluk 160 TL.
                return gunSayisi * (ciftYer ? 160 : 100);
            }

            public override string KiralananYerTipi()
            {
                return "Yer";

            }

            public override string UygulamaAdi()
            {
                return "Çadır";
            }

            public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
            {
                return true;
            }

        }
        class YatLimaniRezervasyon : Rezervasyon
        {
            public override int Fiyat(int gunSayisi, bool ciftYer)
            {
                return gunSayisi * 1000 * (ciftYer ? 2 : 1);
            }

            public override string KiralananYerTipi()
            {
                return "Yer";
            }

            public override string UygulamaAdi()
            {
                return "Yat";
            }

            public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
            {
                return true;
            }

            protected override bool ErtesiGunTemizlikIcinBosBirakilacakMi()
            {
                return false;
            }
            public override void AylikDolulukDurumu()
            {
                Console.Write("      ");
                TarihCetveliniYazdir();
                Console.WriteLine();
                for (int i = 0; i < odaSayisi; i++)
                {
                    Console.Write("" + KiralananYerTipi() + " {0:00}", i + 1);
                    for (int j = 0; j < gunSayisi; j++)
                    {
                        if (rezervasyonDurumu[i, j] == RezervasyonEnum.Bos)
                            Console.Write(" - ");
                        else if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                            Console.Write(" D ");
                        else
                            Console.Write(" - ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Rezervasyon rezervasyon;
            Random _random = new Random();
            int rastgele = _random.Next(1, 101);
            Console.WriteLine(rastgele);

            if (rastgele < 33)
            {
                rezervasyon = new OtelRezervasyon();

            }
            else if (rastgele < 67)
            {

                rezervasyon = new CadirRezervasyon();
            }
            else
            {
                rezervasyon = new YatLimaniRezervasyon();
            }
            rezervasyon.RasgeleDoldur();
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("        " + rezervasyon.UygulamaAdi());
                Console.WriteLine("   1- Bugunku bos "+rezervasyon.KiralananYerTipi() +" goster");
                Console.WriteLine("   2- 30 gunluk doluluk durumu");
                Console.WriteLine("   3- Gun bazinda doluluk oranlari");
                Console.WriteLine("   4- Bugun icin hizli rezervasyon");
                Console.WriteLine("   5- Iki tarih arasi rezervasyon");
                char gunSonuIslemi = '6';
                if (rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi())
                {
                    Console.WriteLine("   6- Bugun icin hizli rezervasyon (yan yana iki yer)");
                    Console.WriteLine("   7- Iki tarih arasi rezervasyon (yan yana iki yer)");
                    gunSonuIslemi = '8';
                }
                Console.WriteLine("   {0}- Gun sonu islemi", gunSonuIslemi);

                char c = Console.ReadKey().KeyChar;
                switch (c)
                {
                    case '1':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bugunku bos yerler");
                            rezervasyon.BugunkuBosOdalar();
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine();
                            Console.WriteLine("30 gunluk doluluk durumu");
                            rezervasyon.AylikDolulukDurumu();
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Gun bazinda doluluk oranlari");
                            rezervasyon.GunBazindaDolulukOranlari();
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bugun icin hizli rezervasyon");
                            rezervasyon.RezervasyonYap();
                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Iki tarih arasi rezervasyon");
                            DateTime date1 = DateTime.Today;
                            DateTime date2 = DateTime.Today;
                            try
                            {
                                Console.Write("Rezervasyon baslangic tarihi (gg/aa/yyyy): ");
                                string baslangicTarihi = Console.ReadLine();
                                date1 = Convert.ToDateTime(baslangicTarihi);

                                Console.Write("Rezervasyon bitis tarihi (gg/aa/yyyy) veya Gün sayisi Giriniz: ");
                                string bitisTarihi = Console.ReadLine();

                                bool sonuc = DateTime.TryParse(bitisTarihi, out date2);

                                if (!sonuc)
                                {

                                    int gunSayisi = Convert.ToInt32(bitisTarihi);
                                    rezervasyon.RezervasyonYap(date1, gunSayisi);
                                }
                                else
                                {
                                    rezervasyon.RezervasyonYap(date1, date2);
                                }
                                
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Tarih formatina dikkat ediniz");
                            }
                            
                            break;
                        }
                    case '6':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bugun icin hizli rezervasyon (yan yana iki yer)");
                            if (rastgele<33)
                            {
                                rezervasyon.GunSonuIslemi();
                            }
                            else
                            {
                                rezervasyon.RezervasyonYap(yanYanaIkiRezervasyon: true);
                            }
                            
                            break;
                        }
                    case '7':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Iki tarih arasi rezervasyon (yan yana iki yer)");
                            DateTime date1 = DateTime.Today;
                            DateTime date2 = DateTime.Today;
                            try
                            {
                                Console.Write("Rezervasyon baslangic tarihi (gg/aa/yyyy): ");
                                string baslangicTarihi = Console.ReadLine();
                                date1 = Convert.ToDateTime(baslangicTarihi);

                                Console.Write("Rezervasyon bitis tarihi (gg/aa/yyyy): ");
                                string bitisTarihi = Console.ReadLine();

                                bool sonuc = DateTime.TryParse(bitisTarihi, out date2);

                                if (!sonuc)
                                {

                                    int gunSayisi = Convert.ToInt32(bitisTarihi);
                                    rezervasyon.RezervasyonYap(date1, gunSayisi);
                                }
                                else
                                {
                                    rezervasyon.RezervasyonYap(date1, date2);
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Tarih formatina dikkat ediniz");
                            }
                            rezervasyon.RezervasyonYap(date1, date2, yanYanaIkiRezervasyon: true);
                            break;
                        }
                    default:
                        {
                            if (c == gunSonuIslemi)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Gun sonu islemi");
                                rezervasyon.GunSonuIslemi();
                            }
                            break;
                        }
                }
            }
        }
    }
}
