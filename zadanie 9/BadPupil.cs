using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс BadPupil, представляющий ученика с низкой успеваемостью, наследуется от базового класса Pupil.
    /// </summary>
    class BadPupil : Pupil
    {
        /// <summary>
        /// Конструктор класса BadPupil, который принимает фамилию ученика и передает её в конструктор базового класса Pupil.
        /// </summary>
        /// <param name="surname"></param>
        public BadPupil(string surname) : base(surname)
        {
            // Тело конструктора пустое, так как вся инициализация (например, установка фамилии) выполняется в конструкторе базового класса Pupil.
        }

        /// <summary>
        /// Переопределение метода Study из базового класса Pupil.
        /// Выводит сообщение о том, что ученик учится плохо.
        /// </summary>
        public override void Study()
        {
            Console.WriteLine(surname + " учится плохо!"); // Используется поле surname (предположительно определено в базовом классе Pupil) для вывода сообщения.
        }

        /// <summary>
        /// Переопределение метода Read из базового класса Pupil.
        /// Выводит сообщение о том, что ученик читает медленно.
        /// </summary>
        public override void Read()
        {
            Console.WriteLine(surname + " читает медленно!"); // Используется поле surname для вывода сообщения.
        }

        /// <summary>
        /// Переопределение метода Write из базового класса Pupil.
        /// Выводит сообщение о том, что ученик пишет с ошибками.
        /// </summary>
        public override void Write()
        {
            Console.WriteLine(surname + " пишет с ошибками!"); // Используется поле surname для вывода сообщения.
        }

        /// <summary>
        /// Переопределение метода Relax из базового класса Pupil.
        /// Выводит сообщение о том, что ученик отдыхает, смотря телевизор.
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine(surname + " отдыхает, смотря телевизор!"); // Используется поле surname для вывода сообщения.
        }
    }
}
