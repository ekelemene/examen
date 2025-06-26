using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Ukrainian наследуется от абстрактного класса Human
    /// </summary>
    class Ukrainian : Human
    {
        /// <summary>
        /// Конструктор вызывает базовый конструктор для инициализации имени
        /// </summary>
        /// <param name="name"></param>
        public Ukrainian(string name) : base(name) { }

        /// <summary>
        /// Переопределение абстрактного метода SayGreeting из базового класса
        /// Реализация приветствия для украинца (на украинском языке)
        /// </summary>
        public override void SayGreeting()
        {
            Console.WriteLine($"{name}: Привiт!");
        }
    }
}
