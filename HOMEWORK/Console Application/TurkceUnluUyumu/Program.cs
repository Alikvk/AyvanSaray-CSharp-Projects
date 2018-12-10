using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkceUnluUyumu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen kelimenin ünlü uyumuna uyup uymadığını kontrol eden program

            bool kontrolInce = false;
            bool kontrolKalın = false;

            string kalinUnluler = "auıo";
            string inceUnluler = "eüiö";
            Console.WriteLine("Bir Kelime giriniz");

            string kelime = Console.ReadLine();

            for (int i = 0; i < kelime.Length; i++)
            {
                if (inceUnluler.IndexOf(kelime[i]) >= 0)
                {
                    kontrolInce = true;
                }
                else if (kalinUnluler.IndexOf(kelime[i]) >= 0)
                {
                    kontrolKalın = true;
                }
            }
            if (kontrolKalın && kontrolInce)
            {
                Console.WriteLine("Büyük ünlü uyyumuna uygun değil");
            }
            else
            {
                Console.WriteLine("Büyük ünlü uyumuna uygundur");
            }



            Console.ReadKey();
        }
    }
}
