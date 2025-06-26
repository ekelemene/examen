using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс User, представляющий пользователя
    /// </summary>
    class User
    {
        //Закрытые поля (private fields) для хранения данных пользователя.
        private string login;
        private string name;
        private string surname;
        private int age;
        /// <summary>
        /// Закрытое поле с модификатором readonly, которое хранит дату заполнения анкеты.
        /// readonly означает, что значение можно установить только в конструкторе.
        /// </summary>
        private readonly DateTime dateFilled;

        /// <summary>
        /// Конструктор класса User, инициализирующий данные пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.dateFilled = DateTime.Now;
        }

        /// <summary>
        /// Метод для вывода информации о пользователе в консоль.
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"Логин: {login}");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Фамилия: {surname}");
            Console.WriteLine($"Возраст: {age}");
            // Вывод даты заполнения анкеты в формате день.месяц.год 
            // Формат :dd.MM.yyyy задает отображение даты в нужном виде.
            Console.WriteLine($"Дата заполнения: {dateFilled:dd.MM.yyyy}");
        }
    }
}
