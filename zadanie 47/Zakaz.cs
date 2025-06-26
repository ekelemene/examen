using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс, представляющий заказ на бронирование мест с указанием фамилии, количества мест и уровня комфортности.
    /// </summary>
    class Zakaz
    {
        /// <summary>
        /// Поля класса для хранения данных заказа
        /// </summary>
        private string fam;
        private int size;
        private string comfort;

        /// <summary>
        /// Свойство для доступа к фамилии заказчика.
        /// </summary>
        public string Fam
        {
            get { return fam; }
            set { fam = value; }
        }

        /// <summary>
        /// Свойство для доступа к количеству мест.
        /// При установке проверяется, что значение положительное.
        /// </summary>
        public int Size
        {
            get { return size; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество мест должно быть положительным!");
                size = value;
            }
        }

        /// <summary>
        /// Свойство для доступа к уровню комфортности.
        /// </summary>
        public string Comfort
        {
            get { return comfort; }
            set { comfort = value; }
        }

        /// <summary>
        /// Конструктор без параметров — задаёт значения по умолчанию.
        /// </summary>
        public Zakaz()
        {
            fam = "Не указано";
            size = 1;
            comfort = "Стандарт";
        }

        /// <summary>
        /// Конструктор с фамилией — остальные параметры по умолчанию.
        /// </summary>
        /// <param name="fam"></param>
        public Zakaz(string fam)
        {
            this.fam = fam;
            size = 1;
            comfort = "Стандарт";
        }

        /// <summary>
        /// Конструктор с фамилией и количеством мест — комфортность по умолчанию.
        /// </summary>
        /// <param name="fam"></param>
        /// <param name="size"></param>
        public Zakaz(string fam, int size)
        {
            this.fam = fam;
            Size = size;
            comfort = "Стандарт";
        }

        /// <summary>
        /// Полный конструктор — инициализирует все поля.
        /// </summary>
        /// <param name="fam"></param>
        /// <param name="size"></param>
        /// <param name="comfort"></param>
        public Zakaz(string fam, int size, string comfort)
        {
            this.fam = fam;
            Size = size;
            this.comfort = comfort;
        }

        /// <summary>
        /// Метод вывода информации о заказе в консоль.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Фамилия: {fam}");
            Console.WriteLine($"Количество мест: {size}");
            Console.WriteLine($"Комфортность: {comfort}");
            Console.WriteLine();
        }
    }
}
