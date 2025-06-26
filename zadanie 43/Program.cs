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
                // Создание отрезка с целочисленными координатами (int)
                // Точка 1: (0, 0), Точка 2: (3, 4) — классический пример, длина будет 5
                Segment<int> intSegment = new Segment<int>(0, 0, 3, 4);
                Console.WriteLine("Отрезок с int:");
                intSegment.ShowInfo();

                // Создание отрезка с координатами типа long (для работы с большими числами)
                Segment<long> longSegment = new Segment<long>(1, 2, 5, 6);
                Console.WriteLine("Отрезок с long:");
                longSegment.ShowInfo();

                // Создание отрезка с координатами типа double (с плавающей точкой — можно дробные значения)
                Segment<double> doubleSegment = new Segment<double>(1.5, 2.5, 4.5, 6.5);
                Console.WriteLine("Отрезок с double:");
                doubleSegment.ShowInfo();
            }
            catch (Exception ex)
            {
                // Если произошла ошибка при выполнении (например, при преобразовании типов) — выведем сообщение
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
