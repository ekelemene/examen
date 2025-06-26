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
            try
            {
                // Создаём точку с координатами типа int
                Point<int> intPoint = new Point<int>(3, 4);
                Console.WriteLine("Точка с int:");
                intPoint.Show();

                // Создаём точку с координатами типа uint (беззнаковое целое)
                Point<uint> uintPoint = new Point<uint>(5, 6);
                Console.WriteLine("\nТочка с uint:");
                uintPoint.Show();

                // // Создаём точку с координатами типа double (числа с плавающей точкой)
                Point<double> doublePoint = new Point<double>(2.5, 3.7);
                Console.WriteLine("\nТочка с double:");
                doublePoint.Show();
            }
            catch (Exception ex)
            {
                // Обработка возможных исключений
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
