using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс для работы с датой, позволяющий хранить дату и получать предыдущий и следующий день.
    /// </summary>
    class DateClass
    {
        /// <summary>
        /// Поле для хранения даты
        /// </summary>
        private DateTime data;

        /// <summary>
        ///  Конструктор по умолчанию, инициализирует дату текущим временем.
        /// </summary>
        public DateClass()
        {
            data = DateTime.Now;
        }

        /// <summary>
        ///  Конструктор, инициализирующий дату по заданным году, месяцу и дню.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        /// <summary>
        /// Свойство для получения и установки даты.
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        ///  Метод для получения даты предыдущего дня.
        /// </summary>
        /// <returns></returns>
        public DateTime PreviousDay()
        {
            return data.AddDays(-1);
        }

        /// <summary>
        /// Метод для получения даты следующего дня.
        /// </summary>
        /// <returns></returns>
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }
    }
}
