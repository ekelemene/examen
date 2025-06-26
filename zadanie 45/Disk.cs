using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Disk реализует интерфейс IShape и представляет геометрическую фигуру — круг
    /// </summary>
    class Disk : IShape
    {
        /// <summary>
        /// Поле для хранения радиуса круга
        /// </summary>
        private double radius;

        /// <summary>
        /// Конструктор класса — инициализирует радиус круга
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Disk(double radius)
        {
            // Проверка на корректность радиуса — он должен быть положительным
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным!");
            }
            this.radius = radius;
        }

        /// <summary>
        /// Метод для вычисления длины окружности (периметра круга)
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// Переопределённый метод ToString для вывода информации об объекте
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Круг с радиусом: {radius}";
        }
    }
}
