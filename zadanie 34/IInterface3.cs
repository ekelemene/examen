using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Интерфейс IInterface3 наследует IInterface2,
    /// а значит включает методы Method1() и Method2() из IInterface1 и IInterface2,
    /// а также добавляет новый метод Method3().
    /// Любой класс, реализующий IInterface3,
    /// должен реализовать все три метода.
    /// </summary>
    interface IInterface3 : IInterface2
    {
        void Method3(); //сетод без реализации
    }
}
