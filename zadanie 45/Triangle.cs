using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс, представляющий треугольник. Реализует интерфейс IShape.
    /// Позволяет рассчитывать периметр и площадь треугольника по его сторонам.
    /// </summary>
    class Triangle : IShape
    {
        /// <summary>
        /// // Стороны треугольника
        /// </summary>
        private double a, b, c;

        /// <summary>
        /// Конструктор. Проверяет возможность существования треугольника по трём сторонам.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c)
        {
            // Проверка корректности сторон (стороны положительные и соблюдается неравенство треугольника)
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || b + c <= a || a + c <= b)
            {
                throw new ArgumentException("Невозможно построить треугольник!");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Вычисление периметра треугольника.
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return a + b + c;
        }

        /// <summary>
        /// Вычисление площади треугольника по формуле Герона.
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            double p = Perimeter() / 2; //полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Переопределённый метод ToString() для отображения информации о треугольнике.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Треугольник со сторонами: {a}, {b}, {c}";
        }
    }
}
