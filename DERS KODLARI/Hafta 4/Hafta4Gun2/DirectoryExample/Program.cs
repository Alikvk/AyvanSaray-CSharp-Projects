using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Oluşturulma Tarihi: " + Directory.GetCreationTime(path));
                    Console.WriteLine("Son Erişim Tarihi: " + Directory.GetLastAccessTime(path));
                    Console.WriteLine("Son Değiştirilme Tarihi:" + Directory.GetLastWriteTime(path));
                    Console.WriteLine("Bulunduğu Dizin Adı:" + Directory.GetParent(path));
                    Console.ReadLine();
                }
                if (Directory.Exists(target))
                {
                    Directory.Delete(target, true);
                }
                Directory.Move(path, target);
                string[] directories = Directory.GetDirectories(@"C:\Test\");
                foreach (string dir in directories)
                {
                    Console.WriteLine(dir);
                }
                File.CreateText(target + @"\NewFile.txt");
                Console.WriteLine("{0} dizinindeki dosya sayısı: {1}", target, Directory.GetFiles(target).Length);
                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine("İşlem Başarısız: {0}", e.ToString());
            }
        }
    }
}
