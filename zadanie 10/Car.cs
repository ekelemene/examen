using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Car, представляющий автомобиль, наследуется от базового класса Vehicle.
    /// </summary>
    class Car : Vehicle
    {
        /// <summary>
        /// Конструктор класса Car, который принимает параметры для инициализации свойств автомобиля
        /// и передает их в конструктор базового класса Vehicle.
        /// </summary>
        /// <param name="x">Координата X (местоположение автомобиля).</param>
        /// <param name="y">Координата Y (местоположение автомобиля).</param>
        /// <param name="price">Цена автомобиля.</param>
        /// <param name="speed">Скорость автомобиля.</param>
        /// <param name="year">Год выпуска автомобиля.</param>
        public Car(int x, int y, double price, int speed, int year)
            : base(x, y, price, speed, year)
        {
            // Тело конструктора пустое, так как вся инициализация выполняется в конструкторе базового класса Vehicle.
        }

        /// <summary>
        /// Переопределение метода ShowInfo из базового класса Vehicle.
        /// Вызывает реализацию метода ShowInfo из базового класса.
        /// </summary>
        public override void ShowInfo()
        {
            // Вызов метода ShowInfo из базового класса Vehicle с помощью ключевого слова base.
            base.ShowInfo();
        }
    }
}
