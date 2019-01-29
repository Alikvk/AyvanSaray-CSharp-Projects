using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGroupBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ogrenciler = Class1.OgrencileriGetir();

            var SiniflardakiEnYuksekOrtalamaliOgrenciler =
                            from Ogrenci in Ogrenciler
                            group Ogrenci by Ogrenci.Sinif into SinifGrubu
                            let EnYuksekOrtalama = SinifGrubu.Max(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                            select new
                            {
                                Sinif = SinifGrubu.Key,
                                EnYuksekOrtalamaliOgrenciler = SinifGrubu.Where(Ogrenci => Ogrenci.Ortalama == EnYuksekOrtalama)
                            };

            Console.WriteLine("Sınıflardaki en yüksek ortalamalı öğrenciler.");

            foreach (var Satir in SiniflardakiEnYuksekOrtalamaliOgrenciler)
            {
                Console.WriteLine("{0}. sınıftaki en yüksek ortalamalı öğrenci ortalaması {1} olan {2} isimli öğrencidir.",
                                  Satir.Sinif,
                                  Satir.EnYuksekOrtalamaliOgrenciler.First().Ortalama,
                                  Satir.EnYuksekOrtalamaliOgrenciler.First().Adi);
            }
            Console.WriteLine("----------------------------------------------------------");

            //Linq Method Syntax
            var SiniflardakiEnYuksekOrtalamaliOgrencilerMS =
                                Ogrenciler.GroupBy(Ogrenci => Ogrenci.Sinif)
                                .Select(SinifGrubu => new {
                                    SinifGrubu = SinifGrubu,
                                    EnYuksekOrtalama = SinifGrubu.Max(SiniftakiOgrenci => SiniftakiOgrenci.Ortalama)
                                })
                                .Select(Satir => new {
                                    Sinif = Satir.SinifGrubu.Key,
                                    EnYuksekOrtalamaliOgrenci = Satir.SinifGrubu.Where(Ogrenci => Ogrenci.Ortalama == Satir.EnYuksekOrtalama)
                                });

            Console.WriteLine("Sınıflardaki en yüksek ortalamalı öğrenciler.");

            foreach (var Satir in SiniflardakiEnYuksekOrtalamaliOgrencilerMS)
            {
                Console.WriteLine("{0}. sınıftaki en yüksek ortalamalı öğrenci ortalaması {1} olan {2} isimli öğrencidir.",
                                  Satir.Sinif,
                                  Satir.EnYuksekOrtalamaliOgrenci.First().Ortalama,
                                  Satir.EnYuksekOrtalamaliOgrenci.First().Adi);
            }
            Console.ReadLine();
        }
    }
}
