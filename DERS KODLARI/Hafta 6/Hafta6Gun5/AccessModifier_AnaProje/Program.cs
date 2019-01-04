using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier_AnaProje
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kisi k = new Kisi();
            k.KrediliTarih = 123123;
            k.Ad = "Ali";
            k.Yas = 50;
            Ogrenci ogr = new Ogrenci();
            ogr.Id = 123;
            Console.ReadLine();
        }
    }
}
