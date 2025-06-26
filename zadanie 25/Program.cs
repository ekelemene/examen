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
                Console.Write("Введите количество клиентов: ");
                int n = Convert.ToInt32(Console.ReadLine());
                // Создаём массив клиентов указанного размера
                InsuranceClient[] clients = new InsuranceClient[n];

                int i;
                for (i = 0; i < n; i++)// Цикл для ввода данных каждого клиента
                {
                    Console.WriteLine("\nКлиент " + (i + 1) + ":");
                    Console.Write("Имя: ");
                    string name = Console.ReadLine(); // Ввод имени клиента
                    Console.Write("Вид страховки: ");
                    string type = Console.ReadLine(); // Ввод типа страховки
                    Console.Write("Размер страховки: ");
                    double amount = Convert.ToDouble(Console.ReadLine()); // Ввод суммы страховки
                    // Создаём нового клиента с введёнными данными и добавляем в массив
                    clients[i] = new InsuranceClient(name, type, amount);
                }

                // Выводим заголовок для клиентов с автостраховкой и суммой > 2000
                Console.WriteLine("\nКлиенты с автостраховкой на сумму > 2000 руб.:");
                int autoCount = 0; // Счётчик таких клиентов
                bool found = false; // Флаг для отслеживания, найдены ли такие клиенты
                // Проходим по всем клиентам
                for (i = 0; i < clients.Length; i++)
                {
                    //// Проверяем, что тип страховки — "автомобиль" (игнорируя регистр) и сумма > 2000
                    if (clients[i].InsuranceType.ToLower() == "автомобиль" && clients[i].InsuranceAmount > 2000)
                    {
                        clients[i].ShowInfo(); // Выводим информацию о клиенте
                        found = true; // Устанавливаем флаг, что найден хотя бы один клиент
                        autoCount++; // Увеличиваем счётчик
                    }
                }
                // Если не найдено ни одного клиента с таким условием, выводим сообщение
                if (!found)
                {
                    Console.WriteLine("Клиенты не найдены.");
                }
                // Выводим общее количество клиентов с автостраховкой
                Console.WriteLine("Количество клиентов с автостраховкой: " + autoCount);
            }
            catch (FormatException)
            {
                // Если пользователь ввёл не число там, где ожидалось, выводим ошибку
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                // Общий обработчик ошибок — выводит сообщение об ошибке
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
