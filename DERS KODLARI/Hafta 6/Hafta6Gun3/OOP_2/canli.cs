using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
     class Canli
    {
        public int ayak;
        public int el;
        public string tur;
    }
    class Insan : Canli
    {
        public void Konus()
        {
            Console.WriteLine("Selam benimle {0} adet elim ve {1} adet ayağım vardır",el,ayak);
            Console.ReadLine();
        }
       
    }
    class Kopek : Canli
    {
        public void Havla()
        {
            Console.WriteLine("Hav");
            Console.ReadLine();
        }
    }
}
