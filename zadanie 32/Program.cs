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
            // Создаём массив из 3-х объектов типа Tovar (родительский класс)
            Tovar[] tovars = new Tovar[3];
            //Заполняем массив объектами разных подклассов 
            tovars[0] = new Obuv("Кроссовки", 5000, 42, 2);
            tovars[1] = new Odejda("Футболка", 1000, "Синий", 5);
            tovars[2] = new Posuda("Тарелка", 200, 0.5, 10);

            int i;
            for (i = 0; i < tovars.Length; i++)// Перебираем все товары в массиве
            {
                Console.WriteLine("Товар " + (i + 1) + ":");// Печатаем порядковый номер товара
                tovars[i].Print();//Вызываем метод Print() — благодаря полиморфизму 
                                  // будет вызван соответствующий метод из подкласса
            }
        }
    }
}
