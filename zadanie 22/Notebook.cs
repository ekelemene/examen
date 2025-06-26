using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Объявление структуры Notebook (структура — это тип значений, как int или double)
    /// </summary>
    struct Notebook
    {
        /// <summary>
        /// Приватные поля, содержащие информацию о ноутбуке
        /// </summary>
        private string model;
        private string manufacturer;
        private double price;

        /// <summary>
        /// Пользовательский конструктор, инициализирующий все поля
        /// </summary>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        /// <summary>
        /// Метод для отображения информации о ноутбуке
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Модель: " + model);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
        }
    }
}
