using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakuchi.HelloWord
{
    class Program_4
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            List<int> listen = new List<int>();
            listen.Add(1);
            listen.Add(2);
            listen.Add(3);


            Console.WriteLine("Simple List:");
            Console.WriteLine(listen[0]);
            Console.WriteLine(listen[1]);
            Console.WriteLine(listen[2]);
            Console.ReadKey();
            Console.Clear();

            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            Console.WriteLine("Simple Array:");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Simple Enum:");
            Console.WriteLine(En.one);
            Console.WriteLine(En.two);
            Console.WriteLine(En.three);
            Console.ReadKey();
            Console.Clear();
        }        
    }
}
