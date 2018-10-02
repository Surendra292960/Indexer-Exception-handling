using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Exception6
    {
        static void Main(string[] args)
        {
            try
            {

                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Rest of the code");
            Console.ReadLine();
        }
    }
}
