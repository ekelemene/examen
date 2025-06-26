using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Calculator реализует простейший калькулятор с 4 базовыми операциями
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Метод сложения: принимает два числа и возвращает их сумму
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Метод вычитания: принимает два числа и возвращает их разность (a - b)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sub(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Метод умножения: принимает два числа и возвращает их произведение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Mul(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Метод деления: делит a на b, но проверяет деление на ноль
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public double Div(double a, double b)
        {
            if (b == 0)
            {
                // Если делитель равен 0 — выбрасываем исключение, чтобы не произошло ошибки выполнения
                throw new DivideByZeroException("Деление на ноль недопустимо!");
            }
            return a / b;
        }
    }
}
