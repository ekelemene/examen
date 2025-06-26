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
            // Создаём точку A с координатами (0, 0)
            Point p1 = new Point(0, 0, "A");
            // Создаём точку B с координатами (0, 3)
            Point p2 = new Point(0, 3, "B");
            // Создаём точку C с координатами (4, 0)
            Point p3 = new Point(4, 0, "C");
            // Создаём точку D с координатами (4, 3)
            Point p4 = new Point(4, 3, "D");
            // Создаём четырёхугольник из этих четырёх точек
            Figure figure = new Figure(p1, p2, p3, p4);

            // Вызываем метод, который вычислит и выведет периметр фигуры
            figure.PerimeterCalculator();
        }
    }
}
