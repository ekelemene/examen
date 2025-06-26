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
                //Создаем массив точек с заданными координатами
                Point[] points = new Point[]
                {
                    new Point(1, 2),
                    new Point(-1, 3),
                    new Point(-2, -4),
                    new Point(3, -5)
                };
                // Выводим информацию по каждой созданной точке
                Console.WriteLine("Созданные точки:");
                foreach (Point p in points)
                {
                    p.ShowInfo();
                }

                Console.WriteLine();
                // Выводим статистику: сколько точек создано в каждой четверти и всего
                Point.ShowQuadrantCounts();
            }
            catch (Exception ex)
            {
                // Обработка возможных ошибок во время выполнения программы
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
