using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BitArrayCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bit Array kısmında and,or, xor yapmadan önce clone yapmamız gereklidir.
            byte[] sayilar = { 18, 55 };
            BitArray bitDizisi = new BitArray(sayilar);
            Console.WriteLine("Bit Sayisi :" + bitDizisi.Count);
            Console.WriteLine();
            Console.WriteLine("Normal Sonuç");
            EkranaYaz(bitDizisi);
            BitArray Not_bitDizisi = bitDizisi.Not();
            Console.WriteLine();
            Console.WriteLine("Not Sonuç : ");
            EkranaYaz(Not_bitDizisi);

            BitArray Or_bitDizisi = bitDizisi.Or(Not_bitDizisi);
            Console.WriteLine("Or Sonuç");
            EkranaYaz(Or_bitDizisi);
        }
        public static void EkranaYaz(BitArray ba)
        {
            Console.WriteLine();
            for (int i = 0; i < ba.Count; i++)
            {
                Console.WriteLine("{0,-6}",ba[i]);
                if ((i + 1) % 8 == 0)
                {
                    Console.WriteLine();
                }
            }
            
        }
    }
}
