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
            //ввод и сохранение
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Создание нового объекта класса User,
            User user = new User(login, name, surname, age);
            //Вызов метода ShowInfo
            user.ShowInfo();
        }
    }
}
