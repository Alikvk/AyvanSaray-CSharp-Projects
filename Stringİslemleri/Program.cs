using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringİslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //String İşlemleri
            // Çalıştırılmak İstenilen kısmı uncomment yapıp çalıştırabilirsiniz
            //****************  REPLACE *****************//
            //string cumle = "Selam Nasılsın";
            //Console.WriteLine(cumle);
            //string yenicumle = cumle.Replace("Selam Nasılsın","Slm nbr") ;
            //Console.WriteLine(yenicumle);
            //****************  REMOVE *****************//
            //string cumle = "Selam Nasılsın";
            //Console.WriteLine(cumle);
            //string yenicumle = cumle.Remove(0,6);
            //Console.WriteLine(yenicumle);

            //****************  SUBSTRING *****************//

            //string cumle = "Selam Nasılsın";
            //Console.WriteLine(cumle);
            //string yenicumle = cumle.Substring(0, 6);
            //Console.WriteLine(yenicumle);

            //****************  TRIM,TRIMSTART,TRIMEND *****************//
            //TRIM: Cümle içindeki  boşlukları siler
            //TRIMSTART : Cümle başındaki boşlukları siler
            //TRIMEND : Cümle sonundaki boşlukları siler

            //string cumle = "       Selam Nasılsın      ";
            //Console.WriteLine(cumle);
            //string yenicumle = cumle.TrimStart();
            //string yenicumle = cumle.TrimEnd();
            //Console.WriteLine(yenicumle);

            //****************  TO LOWER *****************//

            //string cumle = "SELAM ARKADAŞLAR";
            //Console.WriteLine(cumle);
            //string yenicumle = cumle.ToLower();
            //Console.WriteLine(yenicumle);

            //****************  TO UPPER *****************//

            //string cumle = "selam arkadaşlar";
            //Console.WriteLine(cumle);
            //string yenicumle = cumle.ToUpper();
            //Console.WriteLine(yenicumle);

            //****************  SPLİT *****************//

            //1.Yol for döngüsü ile
            //string cumle = "çorba,pilav,faulye";
            //for (int i = 0; i < cumle.Split(',').Length; i++)
            //{
            //    Console.WriteLine(cumle.Split(',')[i]);
            //}
            //2. Yol Dizi Tanımlayarak
            //string cumle = "Direnç Aşkar Nurettin Armut";
            //string[] dizi = cumle.Split(' ');
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
        }
    }
}
