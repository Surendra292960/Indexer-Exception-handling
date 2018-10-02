using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int y = int.Parse(Console.ReadLine());

            int z = x / y;
            Console.WriteLine("The result is:" + z);
            Console.WriteLine("End of the Pogram");
            Console.ReadLine();
        }
    }
}
