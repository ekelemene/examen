using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс MyClass реализует интерфейс InterfaceC
    /// А так как InterfaceC наследуется от InterfaceA и InterfaceB,
    ///  MyClass обязан реализовать все методы из этих трёх интерфейсов
    /// </summary>
    class MyClass : InterfaceC
    {
        /// <summary>
        ///  Реализация метода из InterfaceA
        /// </summary>
        public void ShowInterfaceA()
        {
            Console.WriteLine("Метод InterfaceA");
        }

        /// <summary>
        /// Реализация метода из InterfaceB
        /// </summary>
        public void ShowInterfaceB()
        {
            Console.WriteLine("Метод InterfaceB");
        }

        /// <summary>
        /// Реализация метода из InterfaceC
        /// </summary>
        public void ShowInterfaceC()
        {
            Console.WriteLine("Метод InterfaceC");
        }
    }
}
