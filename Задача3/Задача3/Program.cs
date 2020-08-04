using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Определен класс дробей, выполнена проверка на 0 в знаменателе (не так как требовалось в домашке, но мне не хватило времени), реализовано сложение,
// реализовано преобразование в десятичную.

namespace Задача3
{
    public class Fraction
    {
        public int numerator, denominator;

        public Fraction(int a, int b) { numerator = a; denominator = b; }

        public void GetInfo()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }

        public void Add(Fraction fract)
        {
            if (this.denominator != fract.denominator)
            {
                if (this.denominator % fract.denominator == 0)
                {
                    this.numerator += fract.numerator * (this.denominator / fract.denominator);
                }
                else if(fract.denominator % this.denominator == 0)
                {
                    this.numerator = this.numerator*(fract.denominator / this.denominator) + fract.numerator;
                    this.denominator = fract.denominator;
                }
                else
                {
                    this.numerator = this.numerator * fract.denominator + fract.numerator * this.denominator;
                    this.denominator = this.denominator * fract.denominator;
                }
            }
            else
            {
                this.numerator += fract.numerator;
            }
        }

        public double Decimalise()
        {
            return Convert.ToDouble(this.numerator) / Convert.ToDouble(this.denominator);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num, denom;
            bool flag;
            string action;
            double dec;

            Console.WriteLine("Enter first fraction (numerator then denominator):");
            num = int.Parse(Console.ReadLine());
            do
            {
                denom = int.Parse(Console.ReadLine());
                flag = denom == 0 ? false : true;
                if (!flag) Console.WriteLine("Denumerator cant be 0. Enter denominator again:");
            } while (!flag);
            Fraction fract1 = new Fraction(num, denom);
            fract1.GetInfo();

            Console.WriteLine("Enter second fraction (numerator then denominator):");
            num = int.Parse(Console.ReadLine());
            do
            {
                denom = int.Parse(Console.ReadLine());
                flag = denom == 0 ? false : true;
                if (!flag) Console.WriteLine("Denumerator cant be 0. Enter denumerator again:");
            } while (!flag);
            Fraction fract2 = new Fraction(num, denom);
            fract2.GetInfo();

            Console.WriteLine("What shall we do with them?");
            action = Console.ReadLine();
            switch(action)
            {
                case "Add":
                    {
                        Console.WriteLine("Adding second to first. Now first is:");
                        fract1.Add(fract2);
                        fract1.GetInfo();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("No such operation, sry.");
                        break;
                    }
            }
            dec = fract1.Decimalise();
            Console.WriteLine($"{dec}");

            Console.ReadKey();
        }
    }
}
