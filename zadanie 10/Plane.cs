using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Plane, представляющий самолет, наследуется от базового класса Vehicle.
    /// </summary>
    class Plane : Vehicle
    {
        /// <summary>
        /// Закрытое поле для хранения высоты полета самолета 
        /// </summary>
        private int altitude;

        /// <summary>
        /// Закрытое поле для хранения количества пассажиров на борту.
        /// </summary>
        private int passengers;

        /// <summary>
        /// Конструктор класса Plane, который принимает параметры для инициализации свойств самолета
        /// и передает базовые параметры в конструктор класса Vehicle.
        /// </summary>
        /// <param name="x">Координата X (местоположение самолета).</param>
        /// <param name="y">Координата Y (местоположение самолета).</param>
        /// <param name="price">Цена самолета.</param>
        /// <param name="speed">Скорость самолета (км/ч).</param>
        /// <param name="year">Год выпуска самолета.</param>
        /// <param name="altitude">Высота полета.</param>
        /// <param name="passengers">Количество пассажиров.</param>
        public Plane(int x, int y, double price, int speed, int year, int altitude, int passengers)
            : base(x, y, price, speed, year)
        {
            // Инициализация полей, специфичных для самолета.
            this.altitude = altitude;
            this.passengers = passengers;
        }

        /// <summary>
        /// Переопределение метода ShowInfo из базового класса Vehicle.
        /// Выводит информацию о самолете, включая данные из базового класса и специфичные для самолета.
        /// </summary>
        public override void ShowInfo()
        {
            // Вызов метода ShowInfo из базового класса Vehicle для вывода общих характеристик (координаты, цена, скорость, год).
            base.ShowInfo();
            // Вывод специфичной для самолета информации: высота полета.
            Console.WriteLine("Высота: " + altitude + " м");
            // Вывод количества пассажиров.
            Console.WriteLine("Пассажиры: " + passengers);
        }
    }
}
