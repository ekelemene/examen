using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Объявление делегата, который принимает два целых числа и возвращает число с плавающей точкой
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    delegate double AverageDelegate(int m, int n);


    internal class Program
    {
        /// <summary>
        /// // Метод, который вычисляет среднее арифметическое чисел от m до n включительно
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        static double Average(int m, int n)
        {
            // Если m больше n, меняем их местами, чтобы всегда идти от меньшего к большему
            if (m > n)
            {
                int temp = m;
                m = n;
                n = temp;
            }
            // Вычисляем количество чисел в диапазоне
            int count = n - m + 1;
            double sum = 0;
            // Считаем сумму чисел от m до n
            int i;
            for (i = m; i <= n; i++)
            {
                sum += i;
            }
            // Возвращаем среднее арифметическое
            return sum / count;
        }

        static void Main(string[] args)
        {
            // Создаем экземпляр делегата, указывая метод Average
            AverageDelegate avgDelegate = new AverageDelegate(Average);

            try
            {
                // Три раза запрашиваем у пользователя диапазон и выводим результат вычисления среднего
                Console.WriteLine("Вычисление 1:");
                Console.Write("Введите m: ");
                int m1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + String.Format("{0:F2}", avgDelegate(m1, n1)));

                Console.WriteLine("\nВычисление 2:");
                Console.Write("Введите m: ");
                int m2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + String.Format("{0:F2}", avgDelegate(m2, n2)));

                Console.WriteLine("\nВычисление 3:");
                Console.Write("Введите m: ");
                int m3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите n: ");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Среднее арифметическое: " + String.Format("{0:F2}", avgDelegate(m3, n3)));
            }
            catch (FormatException)
            {
                // Обработка ошибки, если введены не числа
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                // Общая обработка возможных других ошибок
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
