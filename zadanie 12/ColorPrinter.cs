using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс ColorPrinter наследуется от базового класса Printer
    /// </summary>
    class ColorPrinter : Printer
    {
        /// <summary>
        /// Переопределяем метод Print из базового класса
        /// </summary>
        /// <param name="value"></param>
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
