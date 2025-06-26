using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Odejda (Одежда) наследует функциональность от базового класса Tovar
    /// </summary>
    class Odejda : Tovar
    {
        /// <summary>
        /// поля
        /// </summary>
        private string color;
        private int quantity;

        /// <summary>
        /// Свойство для доступа к полю color (цвет)
        /// </summary>
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        /// <summary>
        /// Свойство для доступа к полю quantity (количество)
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Конструктор: принимает название, цену, цвет и количество,
        /// вызывает базовый конструктор для name и price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="color"></param>
        /// <param name="quantity"></param>
        public Odejda(string name, double price, string color, int quantity)
            : base(name, price)
        {
            this.color = color;
            this.quantity = quantity;
        }

        /// <summary>
        /// Переопределённый метод расчёта суммы с учётом налога 10%
        /// </summary>
        /// <returns></returns>
        public override double CalcSum()
        {
            return price * quantity * 1.1; // Налог 10%
        }

        /// <summary>
        /// Переопределённый метод для вывода полной информации об объекте
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }

}
