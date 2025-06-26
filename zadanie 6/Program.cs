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
            //ввод и чтение  
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            //ввод и чтение
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            //ввод и чтение
            Console.Write("Введите должность: ");
            string position = Console.ReadLine();
            //ввод и чтение
            Console.Write("Введите стаж (в годах): ");
            int experience = Convert.ToInt32(Console.ReadLine());

            //// Создание нового объекта класса Employee, передавая в конструктор введенные фамилию и имя
            Employee employee = new Employee(surname, name);
            // Вызов метода CalculateSalaryAndTax для объекта employee, передавая должность и стаж.
            // Результат метода (кортеж с зарплатой и налогом) декомпозируется в переменные salary и tax.
            var (salary, tax) = employee.CalculateSalaryAndTax(position, experience);
            ///вывод в уонсоль 
            Console.WriteLine($"Сотрудник: {surname} {name}");
            Console.WriteLine($"Должность: {position}");
            Console.WriteLine($"Оклад: {salary:F2}");
            Console.WriteLine($"Налог: {tax:F2}");
        }
    }
}
