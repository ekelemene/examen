using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс ClassRoom, представляющий класс с учениками.
    /// </summary>
    class ClassRoom
    {
        /// <summary>
        /// Закрытое поле для хранения массива учеников (объектов класса Pupil).
        /// </summary>
        private Pupil[] pupils;

        /// <summary>
        /// Конструктор, принимающий двух учеников и инициализирующий массив из 4 элементов.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public ClassRoom(Pupil p1, Pupil p2)
        {
            // Создание массива pupils размером 4.
            pupils = new Pupil[4];
            // Заполнение первых двух элементов переданными учениками.
            pupils[0] = p1;
            pupils[1] = p2;
            // Установка оставшихся элементов в null.
            pupils[2] = null;
            pupils[3] = null;
        }

        /// <summary>
        /// Конструктор, принимающий трех учеников и инициализирующий массив из 4 элементов.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            //// Создание массива pupils размером 4.
            pupils = new Pupil[4];
            // Заполнение первых трех элементов переданными учениками.
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            // Установка последнего элемента в null.
            pupils[3] = null;
        }
        /// <summary>
        /// Конструктор, принимающий четырех учеников и инициализирующий массив из 4 элементов.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            // Создание массива pupils размером 4.
            pupils = new Pupil[4];
            // Заполнение всех элементов переданными учениками.
            pupils[0] = p1;
            pupils[1] = p2;
            pupils[2] = p3;
            pupils[3] = p4;
        }

        /// <summary>
        /// Метод для вывода информации о всех учениках в классе
        /// </summary>
        public void ShowPupils()
        {
            // Переменная i для перебора элементов массива pupils.
            int i;
            // Цикл for для прохода по всем элементам массива pupils.
            for (i = 0; i < pupils.Length; i++)
            {
                // Проверка, что текущий элемент массива не равен null (ученик существует).
                if (pupils[i] != null)
                {
                    // Вывод фамилии ученика с использованием свойства surname (предположительно определено в классе Pupil).
                    Console.WriteLine($"\nУченик: {pupils[i].surname}");
                    // Вызов метода Study для текущего ученика.
                    pupils[i].Study();
                    // Вызов метода Read для текущего ученика.
                    pupils[i].Read();
                    // Вызов метода Write для текущего ученика.
                    pupils[i].Write();
                    // Вызов метода Relax для текущего ученика.
                    pupils[i].Relax();
                }
            }
        }
    }
}
