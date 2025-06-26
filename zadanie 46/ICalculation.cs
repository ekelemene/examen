using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Интерфейс ICalculation задаёт структуру для выполнения математической операции над числом.
    /// </summary>
    interface ICalculation
    {
        /// <summary>
        /// Метод Perform выполняет конкретную математическую операцию над переданным числом.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        double Perform(double number);
    }
}
