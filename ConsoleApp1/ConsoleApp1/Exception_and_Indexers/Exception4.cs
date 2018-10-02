using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    public class DivideByoddNoException : ApplicationException
    {
        public override string Message
        {
         get
            {
                // return "Attempted to divide by odd Number";
                throw new DivideByoddNoException();
            }

        }

    }
    class Exception4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 1st number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 > 0)
            {
               // throw new ApplicationException("Divisor value can be odd Number");
                throw new DivideByoddNoException();
            }
            int z = x / y;
            Console.WriteLine("The result is:" + z);
            Console.WriteLine("End of the program");
            Console.ReadLine();
        }
    }
}

