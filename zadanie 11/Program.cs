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
            // Просим пользователя ввести ключ доступа: "pro", "exp" или ничего
            Console.Write("Введите ключ доступа (pro, exp или пусто для бесплатной версии): ");
            string key = Console.ReadLine().ToLower();


            DocumentWorker worker;  // Объявляем переменную базового типа — она сможет хранить любой вариант
            if (key == "pro") // Если пользователь ввёл "pro"
            {
                worker = new ProDocumentWorker();  // Используем профессиональную версию
            }
            else if (key == "exp") // Если пользователь ввёл "exp"
            {
                worker = new ExpertDocumentWorker(); // Используем экспертную версию
            }
            else // Если ключ не указан или неверный
            {
                worker = new DocumentWorker(); // Используем бесплатную (ограниченную) версию
            }
            // Вызываем методы работы с документом.
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}
