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
            // Создаём экземпляр калькулятора
            Calculator calc = new Calculator();
            try
            {
                // Ввод первого числа
                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                // Ввод второго числа
                Console.Write("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                // Ввод арифметической операции
                Console.Write("Выберите операцию (+, -, *, /): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result;
                // Выполняем соответствующую операцию
                if (operation == '+')
                {
                    result = calc.Add(a, b);
                }
                else if (operation == '-')
                {
                    result = calc.Sub(a, b);
                }
                else if (operation == '*')
                {
                    result = calc.Mul(a, b);
                }
                else if (operation == '/')
                {
                    result = calc.Div(a, b); // Здесь может возникнуть исключение деления на 0
                }
                else
                {
                    // Если операция не распознана — выбрасываем исключение
                    throw new InvalidOperationException("Недопустимая операция!");
                }
                // Вывод результата с округлением до двух знаков
                Console.WriteLine("Результат: " + String.Format("{0:F2}", result));
            }
            catch (FormatException)
            {
                // Ошибка, если пользователь ввёл не число
                Console.WriteLine("Ошибка: введено не число!");
            }
            catch (DivideByZeroException ex)
            {
                // Ошибка деления на ноль
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Ошибка, если операция не распознана
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Общая ошибка — "про запас"
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
