using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//пространство имен
namespace prac44
{
    /// <summary>
    /// главный класс программы
    /// </summary>
    class Program
    {
        /// <summary>
        /// точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Просим пользователя ввести первую сторону прямоугольника
            Console.Write("Введите 1 сторону прямоугольника: ");
            // Считываем число
            double side1 = Convert.ToDouble(Console.ReadLine());
            // Просим ввести вторую сторону
            Console.Write("Введите 2 сторону прямоугольника: ");
            // Считываем второе число
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Создаем новый объект класса Rectangle, передавая ему две стороны
            Rectangle rect1 = new Rectangle(side1, side2);

            // Выводим периметр прямоугольника, используя свойство Perimeter объекта rect1
            Console.WriteLine($"Периметр прямоугольника {rect1.Perimeter}");
            // Выводим площадь прямоугольника, используя свойство Area объекта rect1
            Console.WriteLine($"Площадь прямоугольника {rect1.Area}");

            //ожидание пользоваьеля 
            Console.Read();
        }
    }
}
