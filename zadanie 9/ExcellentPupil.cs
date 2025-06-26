using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс ExcellentPupil, представляющий ученика с отличной успеваемостью, наследуется от базового класса Pupil.
    /// </summary>
    class ExcellentPupil : Pupil
    {
        /// <summary>
        /// Конструктор класса ExcellentPupil, который принимает фамилию ученика и передает её в конструктор базового класса Pupil.
        /// </summary>
        /// <param name="surname"></param>
        public ExcellentPupil(string surname) : base(surname) 
        {
            // Тело конструктора пустое, так как вся инициализация выполняется в конструкторе базового класса Pupil.
        }

        /// <summary>
        /// Переопределение метода Study из базового класса Pupil.
        /// Выводит сообщение о том, что ученик учится отлично.
        /// </summary>
        public override void Study()
        {
            Console.WriteLine(surname + " учится отлично!");
        }

        /// <summary>
        /// Переопределение метода Read из базового класса Pupil.
        /// Выводит сообщение о том, что ученик читает быстро и понимает материал.
        /// </summary>
        public override void Read()
        {
            Console.WriteLine(surname + " читает быстро и всё понимает!");
        }

        /// <summary>
        /// Переопределение метода Write из базового класса Pupil.
        /// Выводит сообщение о том, что ученик пишет аккуратно и точно.
        /// </summary>
        public override void Write()
        {
            Console.WriteLine(surname + " пишет аккуратно и точно!");
        }

        /// <summary>
        /// Переопределение метода Relax из базового класса Pupil.
        /// Выводит сообщение о том, что ученик отдыхает, решая головоломки.
        /// </summary>
        public override void Relax()
        {
            Console.WriteLine(surname + " отдыхает, решая головоломки!");
        }
    }
}
