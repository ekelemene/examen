using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс товар
    /// </summary>
    class Tovar
    {
        /// <summary>
        /// Приватные поля — данные товара
        /// </summary>
        private string name;
        private double price;
        private int kvo; // количество

        /// <summary>
        /// Свойство для доступа к названию товара (name)
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство для доступа к цене товара (price)
        /// </summary>
        public double Price
        {
            get { return price; }
            set
            {
                // Валидация: цена должна быть в диапазоне от 1 до 20
                if (value >= 1 && value <= 20)
                {
                    price = value;
                }
                else
                {
                    // Если значение выходит за пределы, выбрасывается исключение
                    throw new ArgumentException("Цена должна быть от 1 до 20!");
                }
            }
        }
        // Свойство для доступа к количеству товара (kvo)
        public int Kvo
        {
            get { return kvo; }
            set
            {
                // Валидация: количество должно быть от 0 до 10
                if (value >= 0 && value <= 10)
                {
                    kvo = value;
                }
                else
                {
                    // Исключение при неправильном количестве
                    throw new ArgumentException("Количество должно быть от 0 до 10!");
                }
            }
        }


        // Конструктор класса — при создании объекта задаём все поля
        public Tovar(string name, double price, int kvo)
        {
            this.name = name;
            Price = price; // Используем свойство
            Kvo = kvo; // Используем свойство
        }
        // // Метод для расчёта общей стоимости товара (цена * количество)
        public double CalculateCost()
        {
            return price * kvo;
        }
    }
}
