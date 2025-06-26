using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Абстрактный класс Tovar — от него будут наследоваться другие классы товаров
    /// </summary>
    abstract class Tovar
    {
        /// <summary>
        /// поля
        /// </summary>
        protected string name;
        protected double price;

        /// <summary>
        /// Свойство для получения и установки названия товара
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство для получения и установки цены
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Конструктор — инициализирует поля name и price
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Tovar(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Абстрактный метод — должен быть переопределён в каждом подклассе
        /// </summary>
        /// <returns></returns>
        public abstract double CalcSum(); // Метод для расчёта общей стоимости товара

        /// <summary>
        /// Виртуальный метод, который можно переопределить в подклассах
        /// </summary>
        public virtual void Print()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Стоимость: " + String.Format("{0:F2}", CalcSum()));
        }
    }
}
