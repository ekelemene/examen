using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Posuda (Посуда) наследуется от базового класса Tovar
    /// </summary>
    class Posuda : Tovar
    {
        /// <summary>
        /// поля
        /// </summary>
        private double weight;
        private int quantity;

        /// <summary>
        /// Свойство для доступа к весу
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /// <summary>
        ///  Свойство для доступа к количеству
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Конструктор: принимает название, цену, вес и количество,
        /// вызывает конструктор базового класса для name и price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="weight"></param>
        /// <param name="quantity"></param>
        public Posuda(string name, double price, double weight, int quantity)
            : base(name, price)
        {
            this.weight = weight;
            this.quantity = quantity;
        }

        /// <summary>
        /// Переопределённый метод: считает стоимость с учётом веса
        /// Наценка: +1% к цене за каждый килограмм веса
        /// </summary>
        /// <returns></returns>
        public override double CalcSum()
        {
            return price * quantity * (1 + weight * 0.01); // Увеличение цены за вес
        }

        /// <summary>
        /// Переопределённый метод для вывода всей информации о товаре
        /// </summary>
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Вес: " + String.Format("{0:F2}", weight));
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }
}
