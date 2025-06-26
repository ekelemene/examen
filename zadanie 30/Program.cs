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
            try // Блок try для отлова возможных ошибок во время выполнения
            {
                // Создаём массив из объектов типа Tovar (и его наследников)
                Tovar[] tovars = new Tovar[]
                {
                    new Obuv("Кроссовки", 100, 2, 42),
                    new Odejda("Футболка", 20, 5, "Синий"),
                    new Tovar("Книга", 10, 3)
                };

                int i;// Перебираем все товары в массиве
                for (i = 0; i < tovars.Length; i++)
                {
                    Console.WriteLine("Товар " + (i + 1) + ":"); // Выводим номер товара
                    // Вызываем метод ShowInfo(), который полиморфно работает в зависимости от типа объекта
                    tovars[i].ShowInfo(); 
                }
            }
            catch (Exception ex) // Если где-то произойдёт ошибка — она будет перехвачена
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message); // Сообщение об ошибке
            }
        }
    }
}
