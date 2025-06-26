using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс MyClass реализует интерфейс IMath
    /// </summary>
    class MyClass : IMath
    {
        /// <summary>
        /// метод Возвращает значение числа π из стандартной библиотеки Math
        /// </summary>
        /// <returns></returns>
        public double GetPI()
        {
            return Math.PI;
        }

        /// <summary>
        ///  метож Возвращает фиксированное целое число 42
        /// </summary>
        /// <returns></returns>
        public int GetInteger()
        {
            return 42;
        }

        /// <summary>
        ///  метод Возвращает квадрат числа x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Square(double x)
        {
            return x * x;
        }

        /// <summary>
        ///  метод Возвращает квадратный корень числа x с помощью Math.Sqrt
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
