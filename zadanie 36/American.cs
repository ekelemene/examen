using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс American наследуется от базового класса Human
    /// </summary>
    class American : Human
    {
        /// <summary>
        ///  Конструктор класса American, вызывающий конструктор базового класса Human
        /// с передачей параметра name
        /// </summary>
        /// <param name="name"></param>
        public American(string name) : base(name) { }

        /// <summary>
        ///  Переопределение абстрактного (или виртуального) метода SayGreeting из базового класса
        /// Выводит приветствие в американском стиле
        /// </summary>
        public override void SayGreeting()
        {
            Console.WriteLine($"{name}: Hi!");
        }
    }
}
