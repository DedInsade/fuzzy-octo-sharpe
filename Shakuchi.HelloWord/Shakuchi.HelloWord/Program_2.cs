using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakuchi.HelloWord
{
    class Program_2
    {
        static void Main(string[] args)
        {
            int i = 5;
            string User = "username";

            Console.WriteLine(i);
            Console.WriteLine("i is {0}", i.GetType());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(User);
            Console.WriteLine("User is {0}", User.GetType());
            Console.ReadKey();
            Console.Clear();
        }        
    }
}
