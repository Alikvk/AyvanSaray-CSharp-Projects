using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class Yazici
    {
        public void Yazdir(int i)
        {
            Console.WriteLine("Sayısal Değer Yazdırılıyor {0}",i);
        }
        public void Yazdir(string s)
        {
            Console.WriteLine("Metinsel değer yazdırılıyor {0}",s);
        }
    }
}
