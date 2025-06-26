using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Obuv наследуется от базового класса Tovar
    /// </summary>
    class Obuv : Tovar
    {
        /// <summary>
        /// Приватное поле
        /// </summary>
        private int size;
        private int quantity;

        /// <summary>
        ///  Свойство для доступа к размеру
        /// </summary>
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Свойство для доступа к количеству
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        /// <summary>
        /// Конструктор: вызывает базовый конструктор для name и price,
        /// а также инициализирует размер и количество
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="size"></param>
        /// <param name="quantity"></param>
        public Obuv(string name, double price, int size, int quantity)
            : base(name, price)
        {
            this.size = size;
            this.quantity = quantity;
        }

        /// <summary>
        /// Переопределённый метод подсчёта общей суммы (цена * количество)
        /// </summary>
        /// <returns></returns>
        public override double CalcSum()
        {
            return price * quantity;
        }

        /// <summary>
        /// Переопределённый метод вывода информации об обуви
        /// </summary>
        public override void Print()
        {
            base.Print(); // Выводит общую информацию 
            Console.WriteLine("Размер: " + size);
            Console.WriteLine("Количество: " + quantity);
            Console.WriteLine();
        }
    }
}
