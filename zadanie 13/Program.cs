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
            // Создаём массив из 3 объектов типа AbstractHandler
            // Каждый элемент будет обработчиком определённого типа документа
            AbstractHandler[] handlers = new AbstractHandler[3];
            // В первый элемент кладём обработчик XML-файлов
            handlers[0] = new XMLHandler();

            // Во второй — обработчик TXT-файлов
            handlers[1] = new TXTHandler();

            // В третий — обработчик DOC-файлов
            handlers[2] = new DOCHandler();

            int i;
            // Перебираем все обработчики в цикле
            for (i = 0; i < handlers.Length; i++)
            {
                // Выводим тип текущего обработчика (название класса)
                Console.WriteLine("\nРабота с " + handlers[i].GetType().Name + ":");
                //Вызываем методы:
                handlers[i].Create();
                handlers[i].Open();
                handlers[i].Change();
                handlers[i].Save();
            }
        }
    }
}
