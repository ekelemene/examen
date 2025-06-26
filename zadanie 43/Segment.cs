using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Обобщённый класс, представляющий отрезок на двумерной плоскости с координатами типа T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Segment<T>
    {
        /// <summary>
        /// // Координаты начала отрезка и конца
        /// </summary>
        private T x1, y1, x2, y2;

        /// <summary>
        /// Свойство для получения и установки X первой точки
        /// </summary>
        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        /// <summary>
        /// Свойство для получения и установки Y первой точки
        /// </summary>
        public T Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        /// <summary>
        /// Свойство для получения и установки X второй точки
        /// </summary>
        public T X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        /// <summary>
        /// Свойство для получения и установки Y второй точки
        /// </summary>
        public T Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        /// <summary>
        /// Конструктор для инициализации отрезка с заданными координатами
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        /// <summary>
        /// // Метод для вычисления длины отрезка по формуле расстояния между двумя точками
        /// Для вычисления координаты преобразуются в тип double
        /// </summary>
        /// <returns></returns>
        public double CalculateLength()
        {
            double dx = Convert.ToDouble(x2) - Convert.ToDouble(x1); // разница по X
            double dy = Convert.ToDouble(y2) - Convert.ToDouble(y1); // разница по Y
            return Math.Sqrt(dx * dx + dy * dy); // длина отрезка (корень из суммы квадратов)
        }

        /// <summary>
        /// Метод для вывода информации об отрезке и его длине на экран

        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Отрезок: [({x1}, {y1}), ({x2}, {y2})]"); // координаты точек
            Console.WriteLine($"Длина: {CalculateLength():F2}"); // длина с точностью 2 знака после запятой
            Console.WriteLine(); 
        }
    }
}
