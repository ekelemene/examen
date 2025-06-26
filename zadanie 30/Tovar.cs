using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Базовый класс Tovar
    /// </summary>
    class Tovar
    {

        /// <summary>
        /// Поля доступны наследникам (protected)
        /// </summary>
        protected string name;
        protected double price;
        protected int kvo;

        /// <summary>
        /// Свойство для доступа к названию товара
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        ///  Свойство для доступа к цене товара
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// Свойство для доступа к количеству товара
        /// </summary>
        public int Kvo
        {
            get { return kvo; }
            set { kvo = value; }
        }

        /// <summary>
        /// Конструктор класса — устанавливает значения при создании объекта
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="kvo"></param>
        public Tovar(string name, double price, int kvo)
        {
            this.name = name;
            this.price = price;
            this.kvo = kvo;
        }

        /// <summary>
        /// // Виртуальный метод для расчёта стоимости (можно переопределить в наследниках)
        /// </summary>
        /// <returns></returns>
        public virtual double CalculateCost()
        {
            return price * kvo; // Стоимость = цена × количество
        }

        /// <summary>
        /// // Виртуальный метод для вывода информации (можно переопределить в наследниках)
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine("Товар: " + name);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Количество: " + kvo);
            Console.WriteLine("Стоимость: " + String.Format("{0:F2}", CalculateCost()));
            Console.WriteLine();
        }
    }
}
