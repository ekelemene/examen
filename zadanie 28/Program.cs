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
                //создаем объект
                Tour tour = new Tour();

                //Вызов метода без параметров — бесплатный тур по Минскому морю
                tour.TourCalc();

                Console.Write("\nВведите страну: ");
                string country = Console.ReadLine();
                // Вызов метода с одним параметром — страна, тур на 1 день
                tour.TourCalc(country);

                Console.Write("\nВведите страну: ");
                string country2 = Console.ReadLine();
                Console.Write("Введите количество дней: ");
                int days = Convert.ToInt32(Console.ReadLine());
                // Вызов метода с двумя параметрами — страна и количество дней
                tour.TourCalc(country2, days);
            }
            catch (FormatException)
            {
                // Этот блок ловит исключения типа FormatException,
                // которые возникают, если при преобразовании строки в число (например, с помощью Convert.ToInt32)
                // введённый пользователем текст НЕ является правильным числом.
                // Например, если пользователь введёт "abc" вместо числа.
                Console.WriteLine("Ошибка: дни должны быть числом!");
            }
            catch (Exception ex)
            {
                // Этот блок ловит все остальные исключения, которые не были пойманы выше.
                // Переменная ex содержит информацию об ошибке (сообщение, стек вызовов и т.д.).
                // В данном случае мы просто выводим сообщение об ошибке в консоль.
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
