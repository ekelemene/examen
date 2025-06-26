using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём объект класса MyClass, который реализует InterfaceC (и наследуемые им InterfaceA и InterfaceB)
            MyClass myClassOb = new MyClass();

            // Вызываем метод ShowInterfaceA() — выводит "Метод InterfaceA"
            myClassOb.ShowInterfaceA();

            // Вызываем метод ShowInterfaceB() — выводит "Метод InterfaceB"
            myClassOb.ShowInterfaceB();

            // Вызываем метод ShowInterfaceC() — выводит "Метод InterfaceC"
            myClassOb.ShowInterfaceC();
        }
    }
}
