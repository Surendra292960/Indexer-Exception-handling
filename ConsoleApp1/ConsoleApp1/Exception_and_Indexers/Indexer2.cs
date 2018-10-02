using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Indexer2
    {
        private string[] range = new string[5];
        public string this[int indexrange]
        {
            get
            {
                return range[indexrange];
            }

            set
            {
                range[indexrange] = value;
            }
        }

        class TextIndexers
        {
            static void Main(string[] args)
            {
                Indexer2 obj = new Indexer2();
                obj[0] = "ONE";
                obj[1] = "TWO";
                obj[2] = "THREE";
                obj[3] = "FOUR ";
                obj[4] = "FIVE";

                Console.WriteLine("WELCOME TO C# CORNER HOME PAGE\n");
                Console.WriteLine("\n");
                Console.WriteLine("{0}\n,{1}\n,{2}\n,{3}\n,{4}\n",obj[0], obj[1], obj[2], obj[3], obj[4]);
                Console.WriteLine("\n");
                Console.WriteLine("ALS.Senthur Ganesh Ram Kumar\n");
                Console.WriteLine("\n");
                Console.ReadLine();

            }
        }
     }
}
