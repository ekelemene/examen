using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Перечисление (enum) с названиями должностей и значениями часов, необходимых для бонуса
    /// </summary>
    enum Post
    {
        Менеджер = 160,
        Разработчик = 180,
        Тестировщик = 170
    }
    /// <summary>
    /// Класс, который проверяет, заслуживает ли сотрудник бонус
    /// </summary>
    class Accauntant
    {
        /// <summary>
        ///  Метод проверяет, отработал ли сотрудник больше часов, чем указано в enum для его должности
        ///  Возвращает true, если отработано часов больше нормы, иначе false
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="hours"></param>
        /// <returns></returns>
        public bool AskForBonus(Post worker, int hours)
        {
            //Приводим должность к числу (часам) и сравниваем с отработанным временем
            return hours > (int)worker;
        }
    }

}
