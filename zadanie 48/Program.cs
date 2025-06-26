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
                // Создаем три объекта Banknote с разными параметрами
                Banknote banknote1 = new Banknote("Ruble", 100, 5);
                Banknote banknote2 = new Banknote("Dollar", 1, 10);
                Banknote banknote3 = new Banknote();

                Console.WriteLine("Banknote Information:");
                banknote1.ShowInfo();
                banknote2.ShowInfo();
                banknote3.ShowInfo();
                // Добавляем 3 банкноты к первой партии
                banknote1.ChangeQuantity(3);
                Console.WriteLine("After adding 3 banknotes to the first:");
                banknote1.ShowInfo();

                // Проверяем, хватает ли банкнот для покупки на сумму 250
                // Задаем стоимость покупки для проверки
                double cost = 250;
                Console.WriteLine($"Can pay for a purchase of {cost:F2}? {banknote1.CanPay(cost)}");
            }
            catch (ArgumentException ex)
            {
                // Обработка ошибок, связанных с неправильными значениями при установке свойств
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Общая обработка других возможных исключений
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
