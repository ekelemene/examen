using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Абстрактный класс Pupil, представляющий ученика с общими характеристиками и поведением.
    /// Используется как базовый класс для конкретных типов учеников 
    /// </summary>
    abstract class Pupil
    {
        //аоле для хранения фамилии ученика.
        public string surname;

        /// <summary>
        /// Конструктор класса Pupil, инициализирующий фамилию ученика.
        /// </summary>
        /// <param name="surname"></param>
        public Pupil(string surname)
        {
            this.surname = surname;
        }
        /// <summary>
        /// Абстрактный метод Study, определяющий поведение учебы.
        /// Должен быть переопределен в классах-наследниках.
        /// </summary>
        public abstract void Study();

        /// <summary>
        /// Абстрактный метод Read, определяющий поведение чтения.
        /// Должен быть переопределен в классах-наследниках.
        /// </summary>
        public abstract void Read();

        /// <summary>
        /// Абстрактный метод Write, определяющий поведение письма.
        /// Должен быть переопределен в классах-наследниках.
        /// </summary>
        public abstract void Write();

        /// <summary>
        /// Абстрактный метод Relax, определяющий поведение отдыха.
        /// Должен быть переопределен в классах-наследниках.
        /// </summary>
        public abstract void Relax();
    }
}
