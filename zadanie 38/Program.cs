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
                // Создаем массив товаров с начальными данными
                Product[] products = new Product[]
                {
                    new Product("Молоко", "Молочный завод", 2.5, 10, 100),
                    new Product("Хлеб", "Хлебозавод", 1.2, 5, 50),
                    new Product("Молоко", "Ферма", 3.0, 15, 80)
                };

                // Запрос на ввод наименования товара для поиска
                Console.Write("Введите наименование товара: ");
                string searchName = Console.ReadLine();
                Console.WriteLine("\nТовары с наименованием '" + searchName + "':");
                bool found = false; // Флаг, указывающий, найден ли хотя бы один товар
                int i;
                // Цикл перебора всех товаров массива
                for (i = 0; i < products.Length; i++)
                {
                    // Сравнение наименования товара с введенным пользователем (по точному совпадению)
                    if (products[i].Name == searchName)
                    {
                        products[i].ShowInfo(); // Вывод информации о найденном товаре
                        found = true;           // Устанавливаем флаг, что товар найден
                    }
                }
                if (!found)
                {
                    // Сообщение, если совпадений нет
                    Console.WriteLine("Товары не найдены.");
                }

                // Запрос на ввод максимальной цены для дополнительной фильтрации
                Console.Write("\nВведите максимальную цену: ");
                double maxPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Товары с наименованием '" + searchName + "' и ценой не выше " + maxPrice + ":");
                found = false;
                // Цикл перебора товаров с дополнительным условием по цене
                for (i = 0; i < products.Length; i++)
                {
                    // Проверяем совпадение по наименованию и что цена не превышает maxPrice
                    if (products[i].Name == searchName && products[i].Price <= maxPrice)
                    {
                        products[i].ShowInfo();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Товары не найдены.");
                }
                // Запрос на ввод минимального срока хранения для следующей фильтрации
                Console.Write("\nВведите минимальный срок хранения (дней): ");
                int minShelfLife = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Товары со сроком хранения больше " + minShelfLife + " дней:");
                found = false;
                // Цикл поиска товаров с сроком хранения больше введенного значения
                for (i = 0; i < products.Length; i++)
                {
                    if (products[i].ShelfLife > minShelfLife)
                    {
                        products[i].ShowInfo();
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("Товары не найдены.");
                }
            }
            catch (FormatException)
            {
                // Обработка ошибки при неверном вводе числовых данных (например, буквы вместо чисел)
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                // Общая обработка всех других ошибок
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
