using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Exception2
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
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("End of the Pogram");
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.WriteLine("Input must be numeric value");
                Console.WriteLine("End of the Pogram");
            }

            catch (OverflowException ex3)
            {
                Console.WriteLine(ex3.Message);
                Console.WriteLine("Input must be less than 2000");
                Console.WriteLine("End of the Pogram");
            }
            Console.ReadLine();
        }
    }
}
