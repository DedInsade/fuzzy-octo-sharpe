using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakuchi.HelloWord
{
    class Program_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type something");
            var result = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You was wrote: {0}", result);
            Console.ReadKey();
            Console.Clear();
        }        
    }
}
