using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Статический класс Calculator — содержит математические методы для работы с числами
    /// </summary>
    static class Calculator
    {
        /// <summary>
        /// Метод сложения двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Метод вычитания второго числа из первого
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Метод умножения двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Метод деления первого числа на второе с проверкой на деление на ноль
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                // Если второй аргумент равен 0 — выводим ошибку и возвращаем 0
                Console.WriteLine("Ошибка: деление на ноль!");
                return 0;
            }// Иначе выполняем деление
            return a / b;
        }
    }
}
