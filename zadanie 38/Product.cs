using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Класс, представляющий товар с основными свойствами
    /// </summary>
    class Product
    {
        /// <summary>
        /// Закрытые поля для хранения данных о товаре
        /// </summary>
        private string name;
        private string manufacturer;
        private double price;
        private int shelfLife;
        private int quantity;

        /// <summary>
        /// Свойство для доступа и изменения наименования товара
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Свойство для доступа и изменения производителя товара
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        /// <summary>
        /// Свойство для доступа и изменения цены товара
        /// </summary>
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        ///  Свойство для доступа и изменения срока хранения товара (в днях)
        /// </summary>
        public int ShelfLife
        {
            get { return shelfLife; }
            set { shelfLife = value; }
        }

        /// <summary>
        /// Свойство для доступа и изменения количества товара
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        ///  Конструктор класса, инициализирующий все поля при создании объекта
        /// </summary>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="price"></param>
        /// <param name="shelfLife"></param>
        /// <param name="quantity"></param>
        public Product(string name, string manufacturer, double price, int shelfLife, int quantity)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.shelfLife = shelfLife;
            this.quantity = quantity;
        }

        /// <summary>
        /// Метод для вывода полной информации о товаре на консоль
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Наименование: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + String.Format("{0:F2}", price));
            Console.WriteLine("Срок хранения (дней): " + shelfLife);
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }

}
