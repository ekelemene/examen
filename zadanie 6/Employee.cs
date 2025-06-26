using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс сотрудник
    /// </summary>
    class Employee
    {
        /// <summary>
        /// // Закрытые поля для хранения фамилии и имени сотрудника
        /// </summary>
        private string surname, name;

        /// <summary>
        /// Конструктор, который инициализирует фамилию и имя при создании объекта
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        public Employee(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
        }
        /// <summary>
        /// Метод для расчёта зарплаты и налога сотрудника
        /// </summary>
        /// <param name="position"></param>
        /// <param name="experience"></param>
        /// <returns></returns>
        public (double salary, double tax) CalculateSalaryAndTax(string position, int experience)
        {
            double baseSalary = 0; // базовая зарплата для позиции
            switch (position.ToLower())  // Оператор switch для определения базовой зарплаты в зависимости от должности.
            // Метод ToLower() преобразует строку position в нижний регистр для обработки ввода независимо от регистра.
            {
                case "менеджер": baseSalary = 2000; break; // Если должность — "менеджер", базовая зарплата устанавливается в 2000.
                case "разработчик": baseSalary = 3000; break; // Если должность — "разработчик", базовая зарплата устанавливается в 3000.
                case "тестировщик": baseSalary = 1500; break; // Если должность — "тестировщик", базовая зарплата устанавливается в 1500.
                default: baseSalary = 1000; break; // Для всех остальных должностей (не указанных выше) базовая зарплата устанавливается в 1000.
            }
            // Расчет коэффициента надбавки за опыт работы с использованием тернарного оператора.
            // Если стаж > 5 лет, коэффициент = 1.5; если стаж > 2 лет, коэффициент = 1.2; иначе 1.0.
            double experienceBonus = experience > 5 ? 1.5 : experience > 2 ? 1.2 : 1.0;
            // Расчет итоговой зарплаты: базовая зарплата умножается на коэффициент надбавки.
            double salary = baseSalary * experienceBonus;
            // Расчет налога: 13% от итоговой зарплаты.
            double tax = salary * 0.13; // Налог 13%
            // Возврат кортежа, содержащего итоговую зарплату и налог.
            return (salary, tax);
        }
    }
}
