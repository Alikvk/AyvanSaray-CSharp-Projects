using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;
                    Console.WriteLine("Result = {0}",result);

                }
                catch (Exception ex)
                {

                    const string filePath = @"C:\my-log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, please try again");

                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", ex);
                        //throw new FileNotFoundException(filePath + "is not present");
                        //throw ex;

                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Current exception = {0}", exc.GetType().FullName);
                Console.WriteLine("Current exception = {0}", exc.GetType().Name);
                Console.WriteLine("Current exception = {0}", exc.Message);
                Console.WriteLine("Current exception = {0}", exc.GetType().TypeHandle);

                if (exc.InnerException !=null)
                {
                    Console.WriteLine("Inner Excecption = {0}",exc.InnerException.GetType().Name);
                }
            }
            Console.ReadKey();
        }
    }
}
