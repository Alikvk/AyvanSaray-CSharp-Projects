using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KarelerIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Kareler k = new Kareler();
            foreach (int v in k)
            {
                Console.WriteLine(v);
                Thread.Sleep(200);
            }
            
            Console.ReadLine();
        }
        class Kareler : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                return new KarelerEnumerator(); ;
            }
        }
        class KarelerEnumerator : IEnumerator
        {
            //private int currentNumber,squareNumber;
            //public object Current { get { return squareNumber; } }
            //public bool MoveNext()
            //{

            //    currentNumber = currentNumber + 1;
            //    squareNumber = currentNumber * currentNumber;
            //    return true;
            //}
            //public void Reset()
            //{
            //    currentNumber = 0;
            //    squareNumber = 0;
            //}
            private int currentNumber;
            public object Current { get { return currentNumber*currentNumber; } }
            public bool MoveNext()
            {

                ++currentNumber;
                return true;
            }
            public void Reset()
            {
                currentNumber = 0;
            }
        }
    }
}
