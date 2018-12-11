using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string adres = @"C:\TestDizini\NewFile.txt";
            FileStream fs = new FileStream(adres,FileMode.OpenOrCreate);
            FileStream fs2 = new FileStream(adres, FileMode.Append,FileAccess.Write);
            FileStream fs3 = new FileStream(adres, FileMode.Truncate,FileAccess.Write,FileShare.None);
            //File Stream akımının tamponunu temizler
             // Hafızadaki tampon böldeki bilgileri hemen diske yazar
            fs.Flush();
            // FileStream tarafından kullanılan kaynaklar boşaltılır.
            //Tampon bölgeleri diske yazıp serbest bırakıyor.
            //Sistem kaynaklarını serbest bırakıyor
            //File close yapılmadan önce başkaları file'i açıp işlem yapamaz
            fs.Close();

        }
    }
}
