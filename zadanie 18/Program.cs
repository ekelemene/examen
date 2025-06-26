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
            //Создаём объект класса Figura для вызова методов вычисления площади
            Figura figura = new Figura();

            // Площадь квадрата
            Console.Write("Введите сторону квадрата: ");
            double a = Convert.ToDouble(Console.ReadLine());
            figura.ShowArea(a);

            // Площадь прямоугольника
            Console.Write("\nВведите длину прямоугольника: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            figura.ShowArea(a, b);

            // Площадь трапеции
            Console.Write("\nВведите длину первого основания трапеции: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину второго основания трапеции: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту трапеции: ");
            double h = Convert.ToDouble(Console.ReadLine());
            figura.ShowArea(a, b, h);
        }
    }
}
