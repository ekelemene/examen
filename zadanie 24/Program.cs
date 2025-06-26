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
                Console.Write("Введите должность (0 - Менеджер, 1 - Разработчик, 2 - Тестировщик): ");
                int postIndex = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество отработанных часов: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                // Проверяем, что введённое число соответствует допустимому диапазону должностей
                if (postIndex < 0 || postIndex > 2)
                {
                    // Если номер должности вне диапазона, выбрасываем исключение с сообщением об ошибке
                    throw new ArgumentException("Недопустимая должность!");
                }

                //// Преобразуем число в enum Post (0 -> Менеджер, 1 -> Разработчик, 2 -> Тестировщик)
                Post worker = (Post)postIndex;
                // Создаем объект класса Accauntant
                Accauntant acc = new Accauntant();
                // Вызываем метод, который проверяет, положена ли премия
                bool bonus = acc.AskForBonus(worker, hours);
                // Выводим результат проверки: если бонус положен — "положена", иначе — "не положена"
                Console.WriteLine("Премия " + (bonus ? "положена" : "не положена"));
            }
            catch (FormatException)
            {
                // Обработка ошибки, если введены не числа
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибки с сообщением из выброшенного ArgumentException
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Общая обработка любых других ошибок
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
