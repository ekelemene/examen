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
                Console.Write("Введите строку: ");
                string text = Console.ReadLine();
                Console.Write("Выберите цвет (0 - Красный, 1 - Синий, 2 - Зелёный): ");
                int color = Convert.ToInt32(Console.ReadLine());

                // Выводим строку выбранным цветом
                Printer.Print(text, color);
            }
            catch (FormatException)
            {
                // Обрабатываем ситуацию, когда пользователь ввёл не число
                Console.WriteLine("Ошибка: цвет должен быть числом!");
            }
            catch (ArgumentException ex)
            {
                // Обрабатываем ошибку, если цвет вне допустимого диапазона (не 0, 1 или 2)
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Общая обработка других непредвиденных ошибок
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
