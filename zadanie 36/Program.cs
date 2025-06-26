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
            try
            {
                // Создаем массив объектов типа Human, в который помещаем объекты разных наследников:
                // Russian, Ukrainian и American — полиморфизм в действии
                Human[] people = new Human[]
                {
                    new Russian("Ivan"),
                    new Ukrainian("Oleh"),
                    new American("John")
                };

                // Перебираем всех людей из массива и вызываем для каждого метод SayGreeting
                // Каждый объект вызывает свою версию метода (переопределённую в своем классе)
                for (int i = 0; i < people.Length; i++)
                {
                    people[i].SayGreeting();
                }
            }
            catch (Exception ex)
            {
                // В случае ошибки выводим сообщение с описанием исключения
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
