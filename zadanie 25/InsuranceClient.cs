using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс комент
    /// </summary>
    class InsuranceClient
    {
        /// <summary>
        /// // Приватные поля класса, хранящие данные клиента
        /// </summary>
        private string name;
        private string insuranceType;
        private double insuranceAmount;

        /// <summary>
        /// Конструктор класса, инициализирует поля при создании объекта
        /// </summary>
        /// <param name="name"></param>
        /// <param name="insuranceType"></param>
        /// <param name="insuranceAmount"></param>
        public InsuranceClient(string name, string insuranceType, double insuranceAmount)
        {
            this.name = name;
            this.insuranceType = insuranceType;
            this.insuranceAmount = insuranceAmount;
        }

        /// <summary>
        /// Метод для вывода информации о клиенте на экран
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Клиент: " + name);
            Console.WriteLine("Вид страховки: " + insuranceType);
            Console.WriteLine("Размер страховки: " + String.Format("{0:F2}", insuranceAmount));
            Console.WriteLine();
        }

        /// <summary>
        /// // Свойство для чтения типа страховки (только get, изменить нельзя извне)
        /// </summary>
        public string InsuranceType
        {
            get { return insuranceType; }
        }

        /// <summary>
        /// Свойство для чтения суммы страховки (только get, изменить нельзя извне)
        /// </summary>
        public double InsuranceAmount
        {
            get { return insuranceAmount; }
        }
    }
}
