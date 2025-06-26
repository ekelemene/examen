using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        /// <summary>
        ///  Метод Calculate применяет две операции (реализующие ICalculation) к числу.
        /// Сначала выполняется первая операция (calc1), затем вторая (calc2).
        /// </summary>
        /// <param name="number"></param>
        /// <param name="calc1"></param>
        /// <param name="calc2"></param>
        /// <returns></returns>
        static double Calculate(double number, ICalculation calc1, ICalculation calc2)
        {
            double result = calc1.Perform(number); // Сначала прибавляем, например
            return calc2.Perform(result); // Затем результат умножаем
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                double number = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение для сложения: ");
                double addValue = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите коэффициент для умножения: ");
                double multiplyFactor = Convert.ToDouble(Console.ReadLine());

                // Создание объектов операций
                ICalculation add = new Add(addValue);
                ICalculation multiply = new Multiply(multiplyFactor);

                // Выполнение вычисления: сначала сложение, потом умножение
                double result = Calculate(number, add, multiply);
                Console.WriteLine($"Результат: {result:F2}");
            }
            catch (FormatException)
            {
                // Обработка ошибки при вводе нечисловых данных
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (Exception ex)
            {
                // Обработка любых других ошибок
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
