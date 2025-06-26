using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Интерфейс InterfaceC наследуется от InterfaceA и InterfaceB
    ///  Это значит, что любой класс, который реализует InterfaceC,
    ///  обязан реализовать все методы из InterfaceA, InterfaceB и сам метод ShowInterfaceC
    /// </summary>
    interface InterfaceC : InterfaceA, InterfaceB
    {
        /// <summary>
        /// Метод, который должен реализовать класс, реализующий InterfaceC
        /// </summary>
        void ShowInterfaceC();
    }
}
