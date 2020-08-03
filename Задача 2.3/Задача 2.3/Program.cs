using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2._3
{
    class Program
    {
        static int GetInput()
        {
            int x;
            string s;
            bool flag;
            do
            {
                Console.Write("Please enter a number:");
                s = Console.ReadLine();
                flag = int.TryParse(s, out x);
                if (!flag) Console.Write("The recieved input is not a number. ");
            } while (!flag);
            return x;
        }
        static void Main(string[] args)
        {
            int x, sum=0;
            do
            {
                x = GetInput();
                if ((x % 2 != 0) && (x > 0))
                {
                    sum += x;
                }
            } while (x != 0);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
