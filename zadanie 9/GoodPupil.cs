using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс GoodPupil, представляющий ученика с хорошей успеваемостью, наследуется от базового класса Pupil.
    /// </summary>
    class GoodPupil : Pupil
    {
        /// <summary>
        /// Конструктор класса GoodPupil, который принимает фамилию ученика и передает её в конструктор базового класса Pupil.
        /// </summary>
        /// <param name="surname"></param>
        public GoodPupil(string surname) : base(surname) 
        {
            // Тело конструктора пустое, так как вся инициализация (например, установка фамилии) выполняется в конструкторе базового класса Pupil.
        }

        /// <summary>
        /// Переопределение метода Study из базового класса Pupil.
        /// Выводит сообщение о том, что ученик учится хорошо.
        /// </summary>
        public override void Study()
        {
            Console.WriteLine(surname + " учится хорошо!");
        }

        /// <summary>
        /// Переопределение метода Read из базового класса Pupil.
        /// Выводит сообщение о том, что ученик читает в хорошем темпе.
        /// </summary>
        public override void Read()
        {
            Console.WriteLine(surname + " читает в хорошем темпе!");
        }

        /// <summary>
        /// Переопределение метода Write из базового класса Pupil.
        /// Выводит сообщение о том, что ученик пишет правильно.
        /// </summary>
        public override void Write()
        {
            Console.WriteLine(surname + " пишет правильно!");
        }

        /// <summary>
        /// Переопределение метода Relax из базового класса Pupil.
        /// Выводит сообщение о том, что ученик отдыхает, занимаясь спортом.
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine(surname + " отдыхает, занимаясь спортом!");
        }
    }
}
