using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Add реализует интерфейс ICalculation.
    /// Осуществляет операцию сложения с заданным числом.
    /// </summary>
    class Add : ICalculation
    {
        private double value;// Значение, которое будет прибавлено

        /// <summary>
        /// Конструктор. Принимает значение, которое будет использоваться при сложении.
        /// </summary>
        /// <param name="value"></param>
        public Add(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Метод Perform выполняет операцию сложения.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double Perform(double number)
        {
            return number + value;
        }
    }
}
