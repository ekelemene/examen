using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс, представляющий банкноту с названием, номиналом и количеством.
    /// </summary>
    class Banknote
    {
        /// <summary>
        /// Поля класса
        /// </summary>
        private string name;
        private double denomination;
        private int quantity;

        /// <summary>
        /// Свойство для доступа и установки названия банкноты.
        /// При установке проверяется, что название не пустое и не состоит только из пробелов.
        /// </summary>
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty!");
                name = value;
            }
        }

        /// <summary>
        /// Свойство для доступа и установки номинала банкноты.
        /// Номинал должен быть положительным числом.
        /// </summary>
        public double Denomination
        {
            get { return denomination; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Denomination must be positive!");
                denomination = value;
            }
        }

        /// <summary>
        /// Свойство для доступа и установки количества банкнот.
        /// Количество не может быть отрицательным.
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative!");
                quantity = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию, задающий начальные значения.
        /// </summary>
        public Banknote()
        {
            name = "Unknown";
            denomination = 1;
            quantity = 0;
        }

        /// <summary>
        /// Конструктор, инициализирующий название и номинал, количество по умолчанию 0.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="denomination"></param>
        public Banknote(string name, double denomination)
        {
            Name = name;
            Denomination = denomination;
            quantity = 0;
        }

        /// <summary>
        /// Конструктор, инициализирующий все поля.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="denomination"></param>
        /// <param name="quantity"></param>
        public Banknote(string name, double denomination, int quantity)
        {
            Name = name;
            Denomination = denomination;
            Quantity = quantity;
        }

        /// <summary>
        ///  Метод для изменения количества банкнот на заданное значение (положительное или отрицательное).
        /// При этом используется проверка свойства Quantity, которая не позволит уйти в отрицательное количество.
        /// </summary>
        /// <param name="change"></param>
        public void ChangeQuantity(int change)
        {
            Quantity += change; // Срабатывает проверка в сеттере свойства Quantity
        }

        /// <summary>
        /// Проверяет, достаточно ли банкнот для оплаты заданной стоимости.
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public bool CanPay(double cost)
        {
            return denomination * quantity >= cost;
        }

        /// <summary>
        /// Выводит информацию о банкноте и её количестве.
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Banknote: {name}");
            Console.WriteLine($"Denomination: {denomination:F2}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Amount: {denomination * quantity:F2}");
            Console.WriteLine();
        }
    }
}
