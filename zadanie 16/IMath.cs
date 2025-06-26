using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Интерфейс IMath объявляет методы для математических операций
    /// </summary>
    interface IMath
    {
        /// <summary>
        /// поля
        /// </summary>
        /// <returns></returns>
        double GetPI();
        int GetInteger();
        double Square(double x);
        double Sqrt(double x);
    }
}
