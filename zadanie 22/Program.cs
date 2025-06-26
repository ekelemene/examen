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
                Console.Write("Введите модель ноутбука: ");
                string model = Console.ReadLine();
                Console.Write("Введите производителя: ");
                string manufacturer = Console.ReadLine();
                Console.Write("Введите цену: ");
                double price = Convert.ToDouble(Console.ReadLine());

                //Создаём экземпляр структуры Notebook с введёнными данными
                Notebook notebook = new Notebook(model, manufacturer, price);
                //Выводим информацию о ноутбуке
                Console.WriteLine("\nИнформация о ноутбуке:");
                notebook.ShowInfo();
            }
            // Обработка исключения, если пользователь ввёл некорректное число
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: цена должна быть числом!");
            }
            // Общая обработка всех других исключений
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
