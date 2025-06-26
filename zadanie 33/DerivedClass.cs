using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Класс DerivedClass реализует интерфейс IInterface
    /// </summary>
    class DerivedClass : IInterface
    {
        /// <summary>
        ///  Обязательная реализация метода из интерфейса
        /// </summary>
        public void Method()
        {
           // Вывод сообщения в консоль
            Console.WriteLine("Метод, реализованный в классе DerivedClass");
        }
    }
}
