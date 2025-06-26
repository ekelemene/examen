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
                // Бесконечный цикл для ввода заказов, пока пользователь не введёт 'Q'
                while (true)
                {
                    // Запрос фамилии заказчика
                    Console.Write("Введите фамилию (или 'Q' для выхода): ");
                    string fam = Console.ReadLine();
                    // Если пользователь вводит 'Q' (без учёта регистра) — выход из цикла
                    if (fam.ToUpper() == "Q")
                        break;
                    // Запрос количества мест (число)
                    Console.Write("Введите количество мест: ");
                    int size = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите комфортность: ");
                    string comfort = Console.ReadLine();

                    // Создание объекта заказа с введёнными данными
                    Zakaz zakaz = new Zakaz(fam, size, comfort);
                    Console.WriteLine("\nСоздан заказ:");
                    zakaz.Show();
                }
            }
            catch (FormatException)
            {
                // Обработка ошибки при вводе некорректного числа (например, вместо int введена строка)
                Console.WriteLine("Ошибка: количество мест должно быть числом!");
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибок, выбрасываемых в конструкторе Zakaz или методах (например, неверные параметры)
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Общая обработка любых других непредвиденных ошибок
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
