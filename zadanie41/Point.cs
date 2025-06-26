using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Объявление обобщённого класса Point с параметром типа T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Point<T>
    {
        //акрытые поля для хранения координат точки
        private T x;
        private T y;

        /// <summary>
        /// Свойство для доступа к координате X
        /// </summary>
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>
        /// Свойство для доступа к координате Y
        /// </summary>
        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Конструктор, инициализирующий координаты точки
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Метод для вывода координ
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Точка: ({x}, {y})");
        }
    }
}
