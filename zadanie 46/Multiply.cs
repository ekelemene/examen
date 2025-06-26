using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Multiply реализует интерфейс ICalculation и выполняет операцию умножения.
    /// </summary>
    class Multiply : ICalculation
    {
        /// <summary>
        /// Множитель, на который будет умножаться число
        /// </summary>
        private double factor;

        /// <summary>
        /// Конструктор класса Multiply. Устанавливает значение множителя.
        /// </summary>
        /// <param name="factor"></param>
        public Multiply(double factor)
        {
            this.factor = factor;
        }

        /// <summary>
        /// Метод Perform умножает переданное число на заданный множитель.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double Perform(double number)
        {
            return number * factor;
        }
    }
}
