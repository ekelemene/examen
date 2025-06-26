using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Odejda наследуется от базового класса Tovar (товар)
    /// </summary>
    class Odejda : Tovar
    {
        /// <summary>
        /// Закрытое поле для хранения цвета одежды
        /// </summary>
        private string color;

        /// <summary>
        /// Свойство для доступа к полю color
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Конструктор класса, который вызывает конструктор базового класса Tovar
        /// и инициализирует цвет одежды
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="kvo"></param>
        /// <param name="color"></param>
        public Odejda(string name, double price, int kvo, string color)
            : base(name, price, kvo)
        {
            this.color = color;
        }

        /// <summary>
        /// Переопределение метода CalculateCost для расчёта стоимости с налогом 15%
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            //Используем цену и количество из базового класса и добавляем 15% налог
            return price * kvo * 1.15; // Налог 15%
        }

        /// <summary>
        /// Переопределение метода ShowInfo для вывода информации о товаре, включая цвет
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo(); // Вызов метода базового класса для вывода основной информации
            Console.WriteLine("Цвет: " + color); // Вывод цвета одежды
            Console.WriteLine();
        }
    }
}
