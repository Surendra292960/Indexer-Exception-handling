using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Indexer
    {
        string[] person = { "john", "johny", "karl", "Michal" };
        public string this[int index]
        {
            get
            {
                return person[index];
            }

            set
            {
                person[index] = value;
            }
        }
        static void Main(string[] args)
        {
            Indexer obj = new Indexer();
            Console.WriteLine("First Name is:{0} \nSecond Name is:{1}", obj[0], obj[1]);
            Console.ReadLine();
        }
    }
}
