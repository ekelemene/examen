using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Интерфейс IInterface2 наследует интерфейс IInterface1
    /// Это значит, что любой класс, реализующий IInterface2,
    /// должен реализовать методы Method1() и Method2()    
    /// /// </summary>
    interface IInterface2 : IInterface1
    {
        void Method2(); //Дополнительный метод, который нужно реализовать
    }
}
