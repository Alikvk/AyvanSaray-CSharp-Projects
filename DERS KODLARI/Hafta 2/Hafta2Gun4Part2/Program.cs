using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion (type-safe'tir.veri kaybı olmaz)
            int sayi = 5000;
            long dahabuyuksayi = sayi;

            //expilicit conversion (veri kaybı vardır)
            double ondaliklisayi = 154.95;
            int tamsayi = (int)ondaliklisayi;

            //aşağıdaki cast işlemi hata verir
            string yazi = "24121";
            int sonuc = (int)yazi;

            //aşağıdaki cast'ten byte'a değer olarak 192 gelir. 56000%256
            int numara = 56000;
            byte kucukSayi = (byte)numara;
        }
    }
}
