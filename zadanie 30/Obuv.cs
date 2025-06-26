using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Obuv наследуется от класса Tovar (товар)
    /// </summary>
    class Obuv : Tovar
    {
        /// <summary>
        ///  Закрытое поле для хранения размера обуви
        /// </summary>
        private int size;

        /// <summary>
        /// Свойство для доступа к размеру обуви
        /// </summary>
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Конструктор, который вызывает конструктор базового класса Tovar и инициализирует размер обуви
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="kvo"></param>
        /// <param name="size"></param>
        public Obuv(string name, double price, int kvo, int size)
            : base(name, price, kvo)
        {
            this.size = size;
        }

        /// <summary>
        /// Переопределение метода CalculateCost для расчёта стоимости с налогом 10%
        /// </summary>
        /// <returns></returns>
        public override double CalculateCost()
        {
            // Используем поля базового класса (price, kvo) и добавляем 10% налог
            return price * kvo * 1.1; // Налог 10%
        }

        /// <summary>
        /// Переопределение метода ShowInfo для вывода информации о товаре с размером обуви
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo(); // Вызов метода базового класса для вывода основной информации
            Console.WriteLine("Размер: " + size); // Вывод размера обуви
            Console.WriteLine();
        }
    }
}
