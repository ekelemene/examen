using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Определение перечисления (enum), содержащего три цвета
    /// </summary>
    enum Colors
    {
        Красный, //0
        Синий,   //1
        Зелёный  //2
    }
    /// <summary>
    /// Статический класс Printer, содержащий метод Print
    /// </summary>
    static class Printer
    {
        /// <summary>
        /// Метод Print принимает строку и номер цвета (в виде int)
        /// </summary>
        /// <param name="stroka"></param>
        /// <param name="color"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Print(string stroka, int color)
        {
            //Проверка: если передан неверный номер цвета, выбрасывается исключение
            if (color < 0 || color > 2)
            {
                throw new ArgumentException("Недопустимый номер цвета!");
            }
            // Установка соответствующего цвета текста в консоли
            if (color == (int)Colors.Красный)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == (int)Colors.Синий)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (color == (int)Colors.Зелёный)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            // Печать строки цветным текстом
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
