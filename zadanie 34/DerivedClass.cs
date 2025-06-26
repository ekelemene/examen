using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс DerivedClass реализует интерфейс IInterface3,
    /// значит должен определить все методы из этого интерфейса
    /// </summary>
    class DerivedClass : IInterface3
    {
        /// <summary>
        /// Реализация метода Method1 из интерфейса
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("Метод Method1");
        }

        /// <summary>
        /// Реализация метода Method2 из интерфейса
        /// </summary>
        public void Method2()
        {
            Console.WriteLine("Метод Method2");
        }

        /// <summary>
        /// Реализация метода Method3 из интерфейса
        /// </summary>
        public void Method3()
        {
            Console.WriteLine("Метод Method3");
        }
    }
}
