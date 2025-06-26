using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Russian наследуется от абстрактного класса Human
    /// </summary>
    class Russian : Human
    {
        /// <summary>
        /// Конструктор, который вызывает конструктор базового класса для инициализации имени
        /// </summary>
        /// <param name="name"></param>
        public Russian(string name) : base(name) { }

        /// <summary>
        ///  Переопределение абстрактного метода SayGreeting из базового класса
        /// Реализация приветствия для русского человека
        /// </summary>
        public override void SayGreeting()
        {
            Console.WriteLine($"{name}: Hello!");
        }
    }
}
