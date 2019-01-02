using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Yazici yazici = new Yazici();
            yazici.Yazdir("AyvanSaray üniversitesi İşkur Eğitimleri");
            yazici.Yazdir(2019);
            Console.WriteLine("İşlem tamamlanmıştır");
            Console.ReadKey();
        }
    }
}
