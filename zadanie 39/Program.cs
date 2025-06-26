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
                //Создаем массив компьютеров с разными конфигурациями
                Computer[] computers = new Computer[]
                {
                    new Computer("Model1", 8, 500),
                    new Computer("Model2", 16, 1000),
                    new Computer("Model3", 32, 2000)
                };

                double totalCost = 0; // Переменная для накопления общей стоимости всех компьютеров

                int i; // Перебираем каждый компьютер в массиве
                for (i = 0; i < computers.Length; i++)
                {
                    // Вычисляем стоимость текущего компьютера
                    double cost = computers[i].CalculateCost();
                    // Добавляем стоимость к общей сумме
                    totalCost += cost;
                    // Выводим информацию о текущем компьютере
                    Console.WriteLine("Модель: " + computers[i].Model);
                    Console.WriteLine("ОЗУ: " + computers[i].Ram + " ГБ");
                    Console.WriteLine("HDD: " + computers[i].Hdd + " ГБ");
                    Console.WriteLine("Стоимость: " + String.Format("{0:F2}", cost));
                    Console.WriteLine();
                }
                // Выводим общую стоимость всех компьютеров
                Console.WriteLine("Общая стоимость: " + String.Format("{0:F2}", totalCost));
            }
            catch (ArgumentException ex)
            {
                // Обрабатываем исключения при неправильных параметрах RAM или HDD
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                //// Общий обработчик других возможных исключений
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
