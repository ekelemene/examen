using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Определение абстрактного класса Vehicle
    /// </summary>
    abstract class Vehicle
    {
        /// <summary>
        ///  Защищённые поля: доступны в этом классе и наследниках
        /// </summary>
        protected int x, y;
        protected double price;
        protected int speed;
        protected int year;

        /// <summary>
        /// Конструктор: инициализирует поля переданными значениями
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="price"></param>
        /// <param name="speed"></param>
        /// <param name="year"></param>
        public Vehicle(int x, int y, double price, int speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        /// <summary>
        /// Виртуальный метод: выводит информацию о транспорте, можно переопределить в наследниках
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine("Тип: " + GetType().Name);
            Console.WriteLine("Координаты: (" + x + ", " + y + ")");
            Console.WriteLine($"Цена: {price:F2}");
            Console.WriteLine("Скорость: " + speed + " км/ч");
            Console.WriteLine("Год выпуска: " + year);
        }
    }

}
