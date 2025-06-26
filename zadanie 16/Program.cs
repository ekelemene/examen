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
            // Создаём объект класса MyClass для вызова его методов
            MyClass myClass = new MyClass();

            //Выводим значение числа PI, используя метод GetPI объекта myClass
            Console.WriteLine("Число PI: " + myClass.GetPI());
            // Выводим целое число, используя метод GetInteger объекта myClass
            Console.WriteLine("Целое число: " + myClass.GetInteger());
            //Просим пользователя ввести число для вычисления квадрата
            Console.Write("Введите число для вычисления квадрата: ");
            //Считываем строку из консоли, конвертируем её в double и сохраняем в переменную x
            double x = Convert.ToDouble(Console.ReadLine());
            // Вычисляем квадрат числа x и выводим результат
            Console.WriteLine("Квадрат числа: " + myClass.Square(x));
            // Просим пользователя ввести число для вычисления квадратного корня
            Console.Write("Введите число для вычисления корня: ");
            // Считываем новую строку из консоли, конвертируем в double и снова сохраняем в x
            x = Convert.ToDouble(Console.ReadLine());
            // Вычисляем квадратный корень числа x и выводим результат
            Console.WriteLine("Квадратный корень: " + myClass.Sqrt(x));
        }
    }
}
