using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс, описывающий почтовый адрес
    /// </summary>
    class Address
    {
        /// <summary>
        /// приватные поля
        /// </summary>
        private string index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        /// <summary>
        ///  Свойство для доступа к индексу (почтовому коду)
        /// Позволяет получить или установить значение поля index
        /// </summary>
        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        /// <summary>
        /// Свойство для доступа к стране
        /// Позволяет получить или установить значение поля country
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        ///  Свойство для доступа к городу
        /// Позволяет получить или установить значение поля city
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Свойство для доступа к улице
        /// Позволяет получить или установить значение поля street
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Свойство для доступа к номеру дома
        /// Позволяет получить или установить значение поля house
        /// </summary>
        public int House
        {
            get { return house; }
            set { house = value; }
        }

        /// <summary>
        /// Свойство для доступа к номеру квартиры
        /// Позволяет получить или установить значение поля apartment
        /// </summary>
        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
