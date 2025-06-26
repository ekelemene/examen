using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    // Объявляем делегат, который представляет метод для вычисления площади треугольника
    // с тремя параметрами типа double (стороны треугольника) и возвращает double (площадь)
    delegate double TriangleAreaDelegate(double a, double b, double c);
    internal class Program
    {
        /// <summary>
        /// // Метод для вычисления площади треугольника по формуле Герона
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static double S(double a, double b, double c)
        {
            // Проверка корректности сторон треугольника:
            // стороны должны быть положительными и сумма любых двух должна быть больше третьей
            if (a <= 0 || b <= 0 || c <= 0 || (a + b <= c) || (b + c <= a) || (a + c <= b))
            {
                // Если условие не выполнено — выбрасываем исключение
                throw new ArgumentException("Невозможно построить треугольник!");
            }
            // Полупериметр
            double p = (a + b + c) / 2;
            // Формула Герона для площади
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void Main(string[] args)
        {
            // Создаем экземпляр делегата, связывая его с методом S
            TriangleAreaDelegate areaDelegate = new TriangleAreaDelegate(S);

            try
            {
                // Ввод и расчет площади для трех треугольников по очереди
                Console.WriteLine("Треугольник 1:");
                Console.Write("Введите a: ");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь: " + String.Format("{0:F2}", areaDelegate(a1, b1, c1)));

                Console.WriteLine("\nТреугольник 2:");
                Console.Write("Введите a: ");
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь: " + String.Format("{0:F2}", areaDelegate(a2, b2, c2)));

                Console.WriteLine("\nТреугольник 3:");
                Console.Write("Введите a: ");
                double a3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b: ");
                double b3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c: ");
                double c3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Площадь: " + String.Format("{0:F2}", areaDelegate(a3, b3, c3)));
            }
            catch (FormatException)
            {
                // Обработка ошибки, если введённые данные не являются числами
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибки, если стороны не могут образовать треугольник
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Обработка любых других исключений
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
