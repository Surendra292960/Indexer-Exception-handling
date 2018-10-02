using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Exception7
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
                Console.WriteLine("Apple ,Orangee,Banana");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
                Console.WriteLine("rest of the code");
                Console.ReadLine();
            }
        }
    }
}
