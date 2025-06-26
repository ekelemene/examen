using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Интерфейс IShape определяет базовые методы для всех геометрических фигур.
    /// Любая фигура, реализующая этот интерфейс, должна уметь рассчитывать периметр и площадь.
    /// </summary>
    interface IShape
    {
        /// <summary>
        /// Метод для вычисления периметра фигуры.
        /// </summary>
        /// <returns>исловое значение периметра</returns>
        double Perimeter();
        /// <summary>
        /// Метод для вычисления площади фигуры.
        /// </summary>
        /// <returns>Числовое значение площади</returns>
        double Area();
    }
}
