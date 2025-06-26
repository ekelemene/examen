using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс 
    /// </summary>
    class TouristFirm
    {
        /// <summary>
        /// // Приватные поля класса — доступны только внутри класса
        /// </summary>
        private string name;
        private int year;
        private string inn;
        private double profit;

        /// <summary>
        ///  Конструктор — вызывается при создании объекта, инициализирует поля
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        /// <param name="inn"></param>
        /// <param name="profit"></param>
        public TouristFirm(string name, int year, string inn, double profit)
        {
            this.name = name;
            this.year = year;
            this.inn = inn;
            this.profit = profit;
        }

        /// <summary>
        /// // Метод для вывода информации о фирме на экран
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Год создания: " + year);
            Console.WriteLine("ИНН: " + inn);
            Console.WriteLine("Прибыль: " + String.Format("{0:F2}", profit));
            Console.WriteLine();
        }

        /// <summary>
        ///  Свойства — позволяют получить доступ к полям класса из вне, но не изменять их (только get)
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        public string INN
        {
            get { return inn; }
        }

        public double Profit
        {
            get { return profit; }
        }
    }
}
