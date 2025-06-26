using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        /// <summary>
        /// Метод для вывода информации о фигуре.
        /// Принимает объект, реализующий интерфейс IShape,
        /// и отображает его тип, периметр и площадь.
        /// </summary>
        /// <param name="shape"></param>
        static void ShowShapeInfo(IShape shape)
        {
            Console.WriteLine($"Фигура: {shape}"); // Вызывает ToString() у фигуры
            Console.WriteLine($"Периметр: {shape.Perimeter():F2}");
            Console.WriteLine($"Площадь: {shape.Area():F2}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            try
            {
                // Создание треугольника
                Triangle triangle = new Triangle(3, 4, 5);
                // Создание круга
                Disk disk = new Disk(2.5);

                // Вывод информации о фигурах
                ShowShapeInfo(triangle);
                ShowShapeInfo(disk);
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибок с аргументами (например, отрицательный радиус)
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Обработка всех остальных непредвиденных ошибок
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
