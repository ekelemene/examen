using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Figura представляет геометрическую фигуру и умеет считать площадь для разных типов фигур
    /// </summary>
    class Figura
    {
        /// <summary>
        /// Метод вычисляет площадь квадрата, принимает длину стороны 'a'
        /// </summary>
        /// <param name="a"></param>
        public void ShowArea(double a)
        {
            double area = a * a;
            Console.WriteLine("Фигура: Квадрат");
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", area));
        }

        /// <summary>
        /// // Перегруженный метод для вычисления площади прямоугольника, принимает длины двух сторон
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void ShowArea(double a, double b)
        {
            double area = a * b;
            Console.WriteLine("Фигура: Прямоугольник");
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", area));
        }

        /// <summary>
        /// Ещё один перегруженный метод для площади трапеции, принимает два основания и высоту
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="h"></param>
        public void ShowArea(double a, double b, double h)
        {
            double area = (a + b) * h / 2;
            Console.WriteLine("Фигура: Трапеция");
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", area));
        }
    }
}
