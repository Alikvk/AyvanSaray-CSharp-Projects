using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo newdir = new DirectoryInfo(@"C:\Test\HedefDizini\");
            FileInfo NewFile = new FileInfo(@"C:\Test\HedefDizini\NewFile.txt");
            
            if (NewFile.Exists)//File sınıfı if(File.Exist(@"C:\Test\NewFile.txt"))
            {
                //Dosya Silme işlemi
                NewFile.Delete(); //File sınıfı if(File.Delete(@"C:\Test\NewFile.txt"))
            }
            //Dosya oluşturma
            newdir.Create();
            NewFile.CreateText();//File sınıfı File.CreateText(@"C:\Test\NewFile.txt"))
            NewFile.Refresh();
            Console.WriteLine("Oluşturulma Tarihi : " + NewFile.CreationTime);
            Console.WriteLine("Son Erişim Tarihi :" + NewFile.LastAccessTime);
            Console.WriteLine("Son Değiştirilme Tarihi :" + NewFile.LastWriteTime);
            Console.WriteLine("Bulunduğu dizinin Tarihi" + NewFile.DirectoryName);
            Console.WriteLine("Dizinin Adi :" + NewFile.Name);
            Console.WriteLine("Dizinin Tam Adi :" + NewFile.FullName);
            Console.WriteLine("Dosya Uzantısı : "+NewFile.Extension);
            //Dosya koplyalama
            NewFile.CopyTo(@"C:\Test\NewFile.txt");
            Console.ReadKey();
        }
    }
}
