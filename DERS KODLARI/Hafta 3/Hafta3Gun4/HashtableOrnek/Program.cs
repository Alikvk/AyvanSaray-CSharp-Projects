using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Sozluk = new Hashtable();
            Sozluk.Add("araba", "car");
            Sozluk["kitap"] = "book";
            ICollection keys = Sozluk.Keys;
            foreach (var item in keys) // var kısmı string olarakta tanımlanabilir
            {
                Console.WriteLine(item);
            }
            ICollection values = Sozluk.Values;
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("Toplam Kelime = " + Sozluk.Count);
            Console.ReadKey();
        }
    }
}
