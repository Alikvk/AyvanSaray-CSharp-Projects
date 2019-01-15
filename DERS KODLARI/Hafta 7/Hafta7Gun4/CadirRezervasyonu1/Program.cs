using ButikOtelRezervasyonu3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadirRezervasyonu1
{
    class Program
    {
        public class CadirRezervasyonu : Rezervasyon
        {
            CadirRezervasyonu()
            {
                
            }

            const int yerSayisi = 10;
            const int gunSayisi = 30;
            DateTime _simdikiTarih = DateTime.Today;
            int[,] DolulukOrani = new int[2, gunSayisi];


            public void GunlukDolulukOrani()
            {
                Console.WriteLine("Doluluk Oranı");
                Console.Write("    "); TarihCetveliniYazdir();
                Console.WriteLine();
                for (int j = 0; j < gunSayisi; j++)
                {
                    for (int i = 0; i < yerSayisi; i++)
                    {
                        if (rezervasyonDurumu[i, j] == RezervasyonEnum.Dolu)
                        {
                            DolulukOrani[0, j] += 10; // 0 Doluluk oranını tutmakta
                        }
                        else if (rezervasyonDurumu[i, j] == RezervasyonEnum.Temizlik)
                        {
                            DolulukOrani[1, j] += 10; // Temizlik oranını Tutmakta
                        }

                    }

                }

                for (int i = 0; i < 2; i++)
                {
                    if (i == 0) { Console.Write("D % "); }
                    else if (i == 1) { Console.Write("T % "); }

                    for (int j = 0; j < gunSayisi; j++)
                    {
                        Console.Write(" {0:00}", DolulukOrani[i, j]);
                        DolulukOrani[i, j] = 0;
                    }
                    Console.WriteLine();
                }


            }
            public void ikiTarihArasiRezervasyonBuyukCadir(DateTime date1, DateTime date2)
            {
                if (date1 < DateTime.Today)
                {
                    Console.WriteLine("Baslangic tarih bugunden kucuk olamaz");
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
                bool bosYerYok = true;
                for (int i = 0; i < yerSayisi; i++)
                {
                    bool yerMusait = true;
                    for (int j = gun1; j <= gun2; j++)
                    {
                        if (rezervasyonDurumu[i, j] != RezervasyonEnum.Bos || rezervasyonDurumu[i + 1, j] != RezervasyonEnum.Bos)
                        {
                            yerMusait = false;
                            break;
                        }
                    }
                    if ((gun2 + 1) < gunSayisi)
                    {
                        if (rezervasyonDurumu[i, gun2 + 1] != RezervasyonEnum.Bos || (rezervasyonDurumu[i + 1, gun2 + 1] != RezervasyonEnum.Bos))
                        {
                            yerMusait = false;
                        }


                    }
                    if (yerMusait)
                    {
                        bosYerYok = false;
                        for (int j = gun1; j <= gun2; j++)
                        {
                            rezervasyonDurumu[i, j] = RezervasyonEnum.Dolu;
                            rezervasyonDurumu[i + 1, j] = RezervasyonEnum.Dolu;

                        }
                        if ((gun2 + 1) < gunSayisi)
                        {
                            rezervasyonDurumu[i, gun2 + 1] = RezervasyonEnum.Temizlik;
                            rezervasyonDurumu[i + 1, gun2 + 1] = RezervasyonEnum.Temizlik;
                        }

                        Console.WriteLine("{0} ve {1} numarali yer sizin icin ayrildi",i+1, i +2);
                        break;
                    }
                }
                if (bosYerYok)
                    Console.WriteLine("Istediginiz tarihte bos yer yok");
            }
            public void HizliRezervasyonBuyukCadir()
            {
                ikiTarihArasiRezervasyonBuyukCadir(_simdikiTarih, _simdikiTarih);
            }


            // public void IkiTarihArasiRezervasyon
        }
        static void Main(string[] args)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            CadirRezervasyonu cadir = new CadirRezervasyonu();
            cadir.RasgeleDoldur();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("        Çadır Rezervasyonu");
                Console.WriteLine("1-Bugunku bos yerleri goster");
                Console.WriteLine("2-30 gunluk doluluk durumu");
                Console.WriteLine("3-Gunluk Doluluk Oranı");
                Console.WriteLine("4-Bugun icin hizli rezervasyon (Küçük Çadır)");
                Console.WriteLine("5-Iki tarih arasi rezervasyon (Küçük Çadır)");
                Console.WriteLine("6-Bugun icin hizli rezervasyon (Büyük Çadır)");
                Console.WriteLine("7-Iki tarih arasi rezervasyon (Büyük Çadır)");
                Console.WriteLine("8-Gun sonu islemi");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bugunku bos Çadirlar");
                            cadir.BugunkuBosOdalar();
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine();
                            Console.WriteLine("30 gunluk doluluk durumu");
                            cadir.AylikDolulukDurumu();
                            break;
                        }
                    case '3':
                        {

                            Console.WriteLine();
                            Console.WriteLine("Günlük Doluluk Oranı");
                            cadir.GunlukDolulukOrani();
                            break;
                        }

                    case '4':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bugun icin hizli rezervasyon (Küçük Çadır)");
                            cadir.BugunIcinHizliRezervasyon();
                            break;
                        }

                    case '5':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Iki tarih arasi rezervasyon (Küçük Çadır)");
                            DateTime date1 = DateTime.Today;
                            DateTime date2 = DateTime.Today;
                            try
                            {
                                Console.Write("Rezervasyon baslangic tarihi (gg/aa/yyyy): ");
                                string baslangicTarihi = Console.ReadLine();
                                date1 = Convert.ToDateTime(baslangicTarihi);

                                Console.Write("Rezervasyon bitis tarihi (gg/aa/yyyy): ");
                                string bitisTarihi = Console.ReadLine();
                                date2 = Convert.ToDateTime(bitisTarihi);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Tarih formatina dikkat ediniz");
                            }
                            cadir.IkiTarihArasiRezervasyon(date1, date2);
                            break;
                        }
                    case '6':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Bugun icin hizli rezervasyon (Büyük Çadır)");
                            cadir.HizliRezervasyonBuyukCadir();
                            break;
                        }

                    case '7':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Iki tarih arasi rezervasyon (Büyük Çadır)");
                            DateTime date1 = DateTime.Today;
                            DateTime date2 = DateTime.Today;
                            try
                            {
                                Console.Write("Rezervasyon baslangic tarihi (gg/aa/yyyy): ");
                                string baslangicTarihi = Console.ReadLine();
                                date1 = Convert.ToDateTime(baslangicTarihi);

                                Console.Write("Rezervasyon bitis tarihi (gg/aa/yyyy): ");
                                string bitisTarihi = Console.ReadLine();
                                date2 = Convert.ToDateTime(bitisTarihi);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Tarih formatina dikkat ediniz");
                            }
                            cadir.ikiTarihArasiRezervasyonBuyukCadir(date1, date2);
                            break;
                        }
                    case '8':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Gun sonu islemi");
                            cadir.GunSonuIslemi();
                            break;
                        }
                }
            }
        }
    }
}
