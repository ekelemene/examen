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
            // Создание массива vehicles типа Vehicle размером 3 элемента.
            // Vehicle — предполагаемый базовый класс (или абстрактный класс), от которого наследуются Plane, Car и Ship.
            Vehicle[] vehicles = new Vehicle[3];

            // Инициализация первого элемента массива объектом Plane.
            vehicles[0] = new Plane(100, 200, 5000000, 900, 2020, 10000, 150);

            // Инициализация второго элемента массива объектом Car.
            vehicles[1] = new Car(300, 400, 30000, 180, 2018);

            // Инициализация третьего элемента массива объектом Ship.
            vehicles[2] = new Ship(500, 600, 1000000, 50, 2015, 2000, "Майами");

            // Объявление переменной i для перебора элементов массива.
            int i;

            // Цикл for для прохода по всем элементам массива vehicles.
            for (i = 0; i < vehicles.Length; i++)
            {
                // Вывод заголовка для текущего транспортного средства с номером (i + 1) для удобства чтения.
                Console.WriteLine("Информация о транспортном средстве " + (i + 1) + ":");

                // Вызов метода ShowInfo для текущего объекта в массиве vehicles.
                // Благодаря полиморфизму вызывается реализация ShowInfo из соответствующего класса (Plane, Car или Ship).
                vehicles[i].ShowInfo();

                // Вывод пустой строки для разделения информации о разных транспортных средствах.
                Console.WriteLine();
            }
        }
    }
}
