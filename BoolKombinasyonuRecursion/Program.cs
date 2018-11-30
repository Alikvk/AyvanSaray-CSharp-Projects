using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolKombinasyonuRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s;
            int sayi;
            Console.WriteLine("Kaç adet sayi için true false ile gösterilecek bütün fonksiyonları görmek istiyorsunuz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            boolKombinasyonu(sayi);
            Console.ReadKey();
        }
        static void boolKombinasyonu(int n)
        {
            boolKombinasyonuYrd("", n);
        }
        static void boolKombinasyonuYrd(string oncekiler, int n)
        {
            if (n > 0)
            {
                if (oncekiler != "")
                {
                    oncekiler += " , ";
                }
                boolKombinasyonuYrd(oncekiler + "true", n - 1); // Burada recursif bitmeden alttakine geçmiyor kendi içinde tekrar tekrar recursion şeklinde devam etmektedir.
                boolKombinasyonuYrd(oncekiler + "false", n - 1);
            }
            else
            {
                Console.WriteLine(oncekiler);
            }
        }
    }
}
