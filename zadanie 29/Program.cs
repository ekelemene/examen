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
                // Создаём массив из 2 товаров
                Tovar[] tovars = new Tovar[2];
                // Инициализируем товары через конструктор
                tovars[0] = new Tovar("Книга", 15, 5);
                tovars[1] = new Tovar("Ручка", 2, 8);

                // переменная для общей стоимости всех товаров
                double totalCost = 0;
                // Перебираем все товары в массиве
                int i;
                for (i = 0; i < tovars.Length; i++)
                {
                    double cost = tovars[i].CalculateCost(); // вычисляем стоимость конкретного товара (цена * количество)
                    totalCost += cost; // добавляем стоимость к общей сумме
                    // Выводим информацию по каждому товару
                    Console.WriteLine("Товар: " + tovars[i].Name);
                    Console.WriteLine("Цена: " + String.Format("{0:F2}", tovars[i].Price));
                    Console.WriteLine("Количество: " + tovars[i].Kvo);
                    Console.WriteLine("Стоимость: " + String.Format("{0:F2}", cost));
                    Console.WriteLine();
                }
                // После цикла выводим общую стоимость всех товаров
                Console.WriteLine("Общая стоимость: " + String.Format("{0:F2}", totalCost));
            }
            catch (ArgumentException ex)
            {
                // Если в свойствах Price или Kvo был передан неправильный диапазон, выводим ошибку с сообщением
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Обработка любых других исключений, которые могут возникнуть
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
