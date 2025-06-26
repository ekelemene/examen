using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Делегат, указывающий на метод, принимающий два целых числа и возвращающий целое число
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    delegate int SumDelegate(int m, int n);


    internal class Program
    {
        /// <summary>
        /// // Метод вычисляет сумму всех целых чисел от m до n включительно
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Sum(int m, int n)
        {
            // Если m больше n, меняем их местами, чтобы избежать ошибок
            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            int sum = 0;
            // Подсчёт суммы от m до n
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // Создаём делегат, ссылающийся на метод Sum
            SumDelegate sumDelegate = new SumDelegate(Sum);

            try
            {
                // Три вычисления подряд
                for (int i = 1; i <= 3; i++)
                {

                    Console.WriteLine($"Вычисление {i}:");
                    // Ввод границ диапазона
                    Console.Write("Введите m: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    // Вызов делегата для подсчёта суммы и вывод результата
                    Console.WriteLine($"Сумма от {m} до {n}: {sumDelegate(m, n)}");
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                // Ошибка при вводе — если пользователь ввёл не число
                Console.WriteLine("Ошибка: введено не целое число!");
            }
            catch (Exception ex)
            {
                // Общая обработка непредвиденных исключений
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
