using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Point представляет точку на координатной плоскости с координатами x и y
    /// </summary>
    class Point
    {

        /// <summary>
        /// поля// Координаты точки
        ///  Статические поля для подсчёта количества точек в каждой четверти и общего количества точек
        /// </summary>
        private double x, y;
        private static int quadrant1Count, quadrant2Count, quadrant3Count, quadrant4Count, totalCount;

        /// <summary>
        /// Конструктор класса, инициализирует координаты и обновляет счетчики по четвертям
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            // Увеличиваем общий счетчик точек при создании новой точки
            totalCount++;
            // Определяем четверть, в которой находится точка, и увеличиваем соответствующий счетчик
            if (x > 0 && y > 0)
                quadrant1Count++;
            else if (x < 0 && y > 0)
                quadrant2Count++;
            else if (x < 0 && y < 0)
                quadrant3Count++;
            else if (x > 0 && y < 0)
                quadrant4Count++;
            // Если точка лежит на осях (x=0 или y=0), счетчики по четвертям не изменяются
        }

        /// <summary>
        /// Метод для отображения информации о точке — вывод координат с двумя знаками после запятой
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Точка: ({x:F2}, {y:F2})");
        }

        /// <summary>
        /// Статический метод для вывода количества точек в каждой четверти и общего количества точек
        /// </summary>
        public static void ShowQuadrantCounts()
        {
            Console.WriteLine($"Точек в 1-й четверти: {quadrant1Count}");
            Console.WriteLine($"Точек во 2-й четверти: {quadrant2Count}");
            Console.WriteLine($"Точек в 3-й четверти: {quadrant3Count}");
            Console.WriteLine($"Точек в 4-й четверти: {quadrant4Count}");
            Console.WriteLine($"Общее количество точек: {totalCount}");
        }
    }
}
