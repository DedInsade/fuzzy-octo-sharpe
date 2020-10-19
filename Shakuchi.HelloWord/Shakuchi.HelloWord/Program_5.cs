using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakuchi.HelloWord
{
    class Program_5
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            int maxNum = 0;

            Console.WriteLine("Введи три числа:");

            int a1 = int.Parse(Console.ReadLine()); //2
            int a2 = int.Parse(Console.ReadLine()); //2
            int a3 = int.Parse(Console.ReadLine()); //7

            if (a1 >= a2 && a1 >= a3)
            {
                Console.WriteLine("Самое большое число " + a1);
                maxNum = a1;
            }
            else if (a2 >= a1 && a2 >= a3)
            {
                Console.WriteLine("Самое большое число " + a2);
                maxNum = a2;
            }
            else if (a3 >= a1 && a3 >= a2)
            {
                Console.WriteLine("Самое большое число " + a3);
                maxNum = a3;
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("А теперь посмотрим, " + maxNum + " чётное или нет?");

            int realMaxNum = maxNum % 2;

            switch (realMaxNum)
            {
                case 0:
                    Console.WriteLine(maxNum + " - чётное число.");
                    break;
                case 1:
                    Console.WriteLine(maxNum + " - нечётное число.");
                    break;
                default:
                    Console.WriteLine(maxNum + " - какая-то хуйня");
                    break;
            }

            var Text = maxNum < 100 ? " меньше 100" : " больше 100";

            Console.WriteLine(maxNum + Text);

            Console.ReadKey();
        }        
    }
}
