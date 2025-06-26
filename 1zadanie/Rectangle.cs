using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac44
{
    /// <summary>
    /// класс прямоугольник 
    /// </summary>
    class Rectangle
    {
        /// <summary>
        /// поля для хранения значений сторон прямоугольника 
        /// </summary>
        double side1;
        double side2;

        /// <summary>
        /// конструктор принимает и сохраняет 
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        public Rectangle(double side1, double side2)
        {
            //this, чтобы отличить поля класса от параметров конструктора
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Метод для вычисления площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator()
        {
            return side1 * side2; //Возвращаем произведение сторон
        }

        /// <summary>
        /// Метод для вычисления периметра прямоугольника
        /// </summary>
        /// <returns></returns>
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2); //Возвращаем удвоенную сумму сторон
        }
        /// <summary>
        /// Свойство Area предоставляет доступ к площади через метод AreaCalculator
        /// </summary>
        public double Area { get { return AreaCalculator(); } } // Вызываем метод AreaCalculator для получения площади

        /// <summary>
        /// Свойство Perimeter предоставляет доступ к периметру через метод PerimeterCalculator
        /// </summary>
        public double Perimeter { get { return PerimeterCalculator(); } } // Вызываем метод PerimeterCalculator для получения периметра

    }
}
