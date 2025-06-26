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
            try
            {
                // Создаём треугольник с типом double
                Triangle<double> triangle1 = new Triangle<double>(3.0, 4.0, 5.0);
                Console.WriteLine("Треугольник с double:");
                triangle1.ShowInfo(); // Выводим информацию и площадь

                // Создаём треугольник с типом int
                Triangle<int> triangle2 = new Triangle<int>(3, 4, 5);
                Console.WriteLine("\nТреугольник с int:");
                triangle2.ShowInfo(); // Выводим информацию и площадь
            }
            catch (ArgumentException ex)
            {
                // Ловим ошибки, например, если стороны <= 0 или треугольник невалидный
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Ловим все остальные ошибки
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
