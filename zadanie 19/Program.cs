using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Сложение: " + a + " + " + b + " = " + Calculator.Add(a, b));
            Console.WriteLine("Вычитание: " + a + " - " + b + " = " + Calculator.Subtract(a, b));
            Console.WriteLine("Умножение: " + a + " * " + b + " = " + Calculator.Multiply(a, b));
            Console.WriteLine("Деление: " + a + " / " + b + " = " + Calculator.Divide(a, b));
        }
    }
}
