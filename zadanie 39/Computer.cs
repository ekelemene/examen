using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  кдасс компьютер
    /// </summary>
    class Computer
    {
        /// <summary>
        /// приватные поля
        /// </summary>
        private string model;
        private int ram;
        private int hdd;

        /// <summary>
        /// // Свойство для доступа к модели компьютера
        /// </summary>
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        /// <summary>
        /// Свойство для доступа и установки объема RAM
        /// </summary>
        public int Ram
        {
            get { return ram; }
            set
            {
                // Проверка, что значение RAM находится в допустимом диапазоне (2-32 ГБ)
                if (value >= 2 && value <= 32)
                {
                    ram = value;
                }
                else
                {
                    // Генерация исключения при недопустимом значении RAM
                    throw new ArgumentException("ОЗУ должно быть от 2 до 32 ГБ!");
                }
            }
        }

        /// <summary>
        /// Свойство для доступа и установки объема HDD
        /// </summary>
        public int Hdd
        {
            get { return hdd; }
            set
            {
                // Проверка, что значение HDD находится в допустимом диапазоне (200-2000 ГБ)
                if (value >= 200 && value <= 2000)
                {
                    hdd = value;
                }
                else
                {
                    // Генерация исключения при недопустимом значении HDD
                    throw new ArgumentException("HDD должно быть от 200 до 2000 ГБ!");
                }
            }
        }

        /// <summary>
        /// // Конструктор класса, инициализирует все поля с проверками через свойства
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ram"></param>
        /// <param name="hdd"></param>
        public Computer(string model, int ram, int hdd)
        {
            this.model = model;
            Ram = ram;
            Hdd = hdd;
        }

        /// <summary>
        /// Метод для вычисления стоимости компьютера по формуле:
        /// базовая цена 500 + 50 за каждый ГБ RAM + 0.5 за каждый ГБ HDD
        /// </summary>
        /// <returns></returns>
        public double CalculateCost()
        {
            return 500 + ram * 50 + hdd * 0.5;
        }
    }
}
