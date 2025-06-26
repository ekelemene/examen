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
            DerivedClass dClass = new DerivedClass(); //Создаём объект DerivedClass и сохраняем его в переменную типа интерфейса IInterface
            dClass.Method(); //Выведет: Метод реализован в DerivedClass
        }
    }
}
