using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Класс Ship, представляющий корабль, наследуется от базового класса Vehicle.
    /// </summary>
    class Ship : Vehicle
    {
        /// <summary>
        /// Закрытое поле для хранения количества пассажиров на борту.
        /// </summary>
        private int passengers;
        /// <summary>
        /// Закрытое поле для хранения порта приписки корабля.
        /// </summary>
        private string port;

        /// <summary>
        /// Конструктор класса Ship, который принимает параметры для инициализации свойств корабля
        /// и передает базовые параметры в конструктор класса Vehicle.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="price"></param>
        /// <param name="speed"></param>
        /// <param name="year"></param>
        /// <param name="passengers"></param>
        /// <param name="port"></param>
        public Ship(int x, int y, double price, int speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }

        /// <summary>
        /// Переопределение метода ShowInfo из базового класса Vehicle.
        /// Выводит информацию о корабле, включая данные из базового класса и специфичные для корабля.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Пассажиры: " + passengers);
            Console.WriteLine("Порт приписки: " + port);
        }
    }
}
