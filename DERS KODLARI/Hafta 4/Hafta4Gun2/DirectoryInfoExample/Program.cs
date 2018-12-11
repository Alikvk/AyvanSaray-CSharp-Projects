using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanılacak dizini Tanımlama
            DirectoryInfo NewDir = new DirectoryInfo(@"C:\Test\TestDizini");
            try
            {
                //Dizinin var olup olmadığının kontrolü
                if (NewDir.Exists)
                {
                    Console.WriteLine("Dizin Mevcut");
                    //Dizin Silme işlemi
                    NewDir.Delete(true);
                    Console.WriteLine("Dizin Silindi");
                }
                NewDir.Create();
                NewDir.Refresh();//Tarih hatalı verdiği için bu kısımla o kısmı yeniliyoruz
                Console.WriteLine("Klasör Oluşturuldu");
                Console.WriteLine("Oluşturulma Tarihi : "+NewDir.CreationTime);
                Console.WriteLine("Bulunduğu dizinin Tarihi"+NewDir.Parent);
                Console.WriteLine("Dizinin Adi :"+NewDir.Name);
                Console.WriteLine("Dizinin Tam Adi :" + NewDir.FullName);
                Console.WriteLine("Son Erişim Tarihi :" + NewDir.LastAccessTime);
                Console.WriteLine("Son Değiştirilme Tarihi :" + NewDir.LastWriteTime);
                Console.ReadLine();
                //Dizin içerisinde alt dizin oluşturma
                DirectoryInfo SubDir = NewDir.CreateSubdirectory("AltDizin");
                //Alt Dizin içerisinde alt dizin oluşturma
                SubDir.CreateSubdirectory("Alt Dizin 2");
                //GetFiles ile dizindeki dosyaların seçimi
                Console.WriteLine("{0} dizinindeki dosya sayisi {1}",NewDir.FullName,NewDir.GetFiles().Length);
                //GetDirections iel dizindeki klasörlerin seçimi
                Console.WriteLine("{0} dizinindeki klasör sayisi {1}",NewDir.FullName,NewDir.GetDirectories().Length);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Hata Meydana Geldi " + e.ToString());
            }
            Console.ReadKey();
        }
    }
}
