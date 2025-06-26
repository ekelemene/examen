using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс представляет геометрическую фигуру
    /// </summary>
    class Figure
    {
        private Point[] points; // Массив точек, определяющих фигуру
        private string name;    // Название фигуры

        /// <summary>
        /// Конструктор для треугольника.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 }; //создание нового массива из трёх объектов
            name = "Треугольник";
        }
        /// <summary>
        /// Конструктор для четырёхугольника
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 }; // создание нового массива из 4 
            name = "Четырёхугольник";
        }

        /// <summary>
        /// Конструктор для пятиугольника
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="p5"></param>
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 }; // новый массив 5
            name = "Пятиугольник";
        }

        /// <summary>
        /// Метод для вычисления длины стороны между двумя точками.
        ///  Используется формула расстояния между точками: √((x2 - x1)² + (y2 - y1)²)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        /// <summary>
        /// Метод для вычисления и вывода периметра фигуры.
        /// Последняя точка соединяется с первой, чтобы фигура была замкнутой.
        /// </summary>
        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                // // Вычисляем длину стороны от текущей точки до следующей
                // (а последняя соединяется с первой через %)
                perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
            }
            Console.WriteLine($"Фигура: {name}");
            Console.WriteLine($"Периметр: {perimeter}");
        }
    }
}
