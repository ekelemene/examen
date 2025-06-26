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
            // Создаём объект обычного принтера
            Printer printer = new Printer();
            //Создаём объект цветного принтера но храним его в переменной типа Printer
            Printer colorPrinter = new ColorPrinter();

            // Запрашиваем у пользователя строку для печати
            Console.Write("Введите строку для печати: ");
            string input = Console.ReadLine();

            // Печатает строку с помощью обычного принтера (без цвета)
            printer.Print(input);


            // Проверяем, действительно ли объект colorPrinter — это ColorPrinter
            if (colorPrinter is ColorPrinter)
            {
                // Приводим переменную к типу ColorPrinter и вызываем переопределённый метод
                ((ColorPrinter)colorPrinter).Print(input);
            }
        }
    }
}
