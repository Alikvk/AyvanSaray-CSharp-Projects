using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueNonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue kuyruk = new Queue();

            kuyruk.Enqueue("Serdar Yilmaz");
            kuyruk.Enqueue(5);
            kuyruk.Enqueue(5.6);
            foreach (var a in kuyruk)
                Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine();
            object silinen = kuyruk.Dequeue();

            Console.WriteLine("Silinen Öğe : " + silinen);
            foreach (var b in kuyruk)
            {
                Console.WriteLine(b);
            }



            Console.ReadKey();
        }
    }
}
