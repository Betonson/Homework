using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Задача2
{
    class Program
    {
        static bool CheckPlease(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;
            else
            {
                char[] masStr1 = str1.ToCharArray();
                char[] masStr2 = str2.ToCharArray();
                int pos;
                for (int i = 0;i<str2.Length;i++)
                {
                    Console.WriteLine($"Searching for: {masStr2[i]}");
                    pos = Array.IndexOf(masStr1, masStr2[i]);
                    if (pos >= 0)
                    {
                        Array.Clear(masStr1, pos, 1);
                        Console.WriteLine(masStr1);
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("..\\..\\data.txt");
            string controlLine = sr.ReadLine();
            string testLine = sr.ReadLine();
            sr.Close();
            if (CheckPlease(controlLine, testLine))
            {
                Console.WriteLine("Yep");
            }
            else
            {
                Console.WriteLine("Nope");
            }
            Console.ReadKey();
            
        }
    }
}
