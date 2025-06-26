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
                // Запрос года у пользователя
                Console.Write("Введите год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите день: ");
                int day = Convert.ToInt32(Console.ReadLine());

                // Создаем объект DateClass с указанной датой
                DateClass date = new DateClass(year, month, day);
                // Выводим текущую дату в формате дд.мм.гггг
                Console.WriteLine($"Текущая дата: {date.Data:dd.MM.yyyy}");
                // Выводим дату предыдущего дня
                Console.WriteLine($"Предыдущий день: {date.PreviousDay():dd.MM.yyyy}");
                // Выводим дату следующего дня
                Console.WriteLine($"Следующий день: {date.NextDay():dd.MM.yyyy}");
            }
            catch (FormatException)
            {
                // Обработка ошибки, если введено не число
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Обработка ошибки, если введена недопустимая дата
                Console.WriteLine("Ошибка: недопустимая дата!");
            }
            catch (Exception ex)
            {
                // Общая обработка любых других исключений
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
