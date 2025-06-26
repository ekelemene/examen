using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Абстрактный класс Human — базовый класс для всех людей
    /// </summary>
    abstract class Human
    {
        /// <summary>
        /// Защищённое поле для хранения имени человека
        /// </summary>
        protected string name;

        /// <summary>
        /// Свойство для доступа к имени с возможностью чтения и записи
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Конструктор, который инициализирует имя человека при создании объекта
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Абстрактный метод SayGreeting — должен быть реализован в производных классах
        /// Метод отвечает за вывод приветствия от человека
        /// </summary>
        public abstract void SayGreeting();
    }
}
