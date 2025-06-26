using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Обобщённый класс Triangle с ограничением, что T должен реализовывать IComparable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Triangle<T> where T : IComparable
    {
        /// <summary>
        /// // Закрытые поля для сторон треугольника
        /// </summary>
        private T a;
        private T b;
        private T c;

        /// <summary>
        /// Свойство для стороны A с проверкой, что значение > 0
        /// </summary>
        public T A
        {
            get { return a; }
            set
            {
                //Сравниваем значение с default(T) (например, 0 для чисел)
                // Если значение <= 0, выбрасываем исключение
                if (Comparer<T>.Default.Compare(value, default(T)) <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной!");
                }
                a = value;
            }
        }

        // Аналогично для стороны B
        public T B
        {
            get { return b; }
            set
            {
                if (Comparer<T>.Default.Compare(value, default(T)) <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной!");
                }
                b = value;
            }
        }

        // Аналогично для стороны C
        public T C
        {
            get { return c; }
            set
            {
                if (Comparer<T>.Default.Compare(value, default(T)) <= 0)
                {
                    throw new ArgumentException("Сторона должна быть положительной!");
                }
                c = value;
            }
        }
        /// <summary>
        /// Конструктор принимает три стороны, устанавливает свойства
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
            if (!IsValidTriangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)))
            {
                // Проверяем валидность треугольника с помощью метода IsValidTriangle
                // Для проверки конвертируем стороны в double (так как T может быть любым IComparable)
                throw new ArgumentException("Невозможно построить треугольник!");
            }
        }
        /// <summary>
        /// Метод проверяет, что сумма любых двух сторон больше третьей (условие существования треугольника)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }

        /// <summary>
        /// Метод для вычисления площади треугольника по формуле Герона
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            double aVal = Convert.ToDouble(a);
            double bVal = Convert.ToDouble(b);
            double cVal = Convert.ToDouble(c); 
            double p = (aVal + bVal + cVal) / 2;// полупериметр
            return Math.Sqrt(p * (p - aVal) * (p - bVal) * (p - cVal));
        }

        /// <summary>
        /// Метод для вывода информации о треугольнике и его площади
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Треугольник со сторонами: " + a + ", " + b + ", " + c);
            Console.WriteLine("Площадь: " + String.Format("{0:F2}", CalculateArea()));
        }
    }
}
