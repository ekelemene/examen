using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Базовый класс Printer — представляет обычный принтер
    /// </summary>
    class Printer
    {
        /// <summary>
        ///  Виртуальный метод Print — может быть переопределён в наследниках
        /// </summary>
        /// <param name="value"></param>
        public virtual void Print(string value)
        {
            //Печатает переданное значение
            Console.WriteLine(value);
        }
    }
}
