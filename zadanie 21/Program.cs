using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        /// <summary>
        /// Метод, принимающий объект класса (ссылочного типа)
        /// </summary>
        /// <param name="myClass"></param>
        static void ClassTaker(MyClass myClass)
        {
            // Меняет значение поля "change" у объекта класса
            myClass.change = "изменено";
        }

        /// <summary>
        /// Метод, принимающий структуру (значимого типа)
        /// </summary>
        /// <param name="myStruct"></param>
        static void StruktTaker(MyStruct myStruct)
        {
            //Меняет значение поля "change" у копии структуры
            myStruct.change = "изменено";
        }


        static void Main(string[] args)
        {
            try
            {
                //Создаём экземпляр класса и задаём начальное значение поля
                MyClass myClass = new MyClass();
                myClass.change = "не изменено";
                // Создаём экземпляр структуры и задаём начальное значение поля
                MyStruct myStruct = new MyStruct();
                myStruct.change = "не изменено";

                //Вывод значений до вызова методов
                Console.WriteLine("До вызова методов:");
                Console.WriteLine("Класс: " + myClass.change);
                Console.WriteLine("Структура: " + myStruct.change);

                //Передаём объект класса и структуру в соответствующие методы
                ClassTaker(myClass); //передаётся ссылка — объект изменится
                StruktTaker(myStruct);// передаётся копия — оригинал не изменится

                // Вывод значений после вызова методов
                Console.WriteLine("\nПосле вызова методов:");
                Console.WriteLine("Класс: " + myClass.change); // Изменится
                Console.WriteLine("Структура: " + myStruct.change); // Не изменится
            }
            catch (Exception ex)
            {
                // Обработка возможных исключений
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
