using System;
using System.Text.RegularExpressions;

namespace Задача1
{
    class Program
    {
        static bool CheckLoginSimple(string input)
        {
            if ((input.Length <2) || (input.Length > 10))
            {
                return false;
            }
            for (int i = 0;i<input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        }
        //static bool CheckLoginRegex(string input)
        //{

        //}
        static void Main(string[] args)
        {
            string inputStr;
            Console.WriteLine("Введите логин:");
            inputStr = Console.ReadLine();
            Regex myReg = new Regex(@"\b[A-Za-z]{2,10}\b");
            if (CheckLoginSimple(inputStr))
            {
                Console.WriteLine("Fine (Simple)");
            }
            else
            {
                Console.WriteLine("Not fine (Simple)");
            }
            Console.WriteLine(myReg.IsMatch(inputStr));
            Console.ReadKey();
        }
    }
}
