using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Exception3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st number");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number");
                int y = int.Parse(Console.ReadLine());

                int z = x / y;
                Console.WriteLine("The result is:" + z);
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
                Console.ReadLine();
        }
    }
}
