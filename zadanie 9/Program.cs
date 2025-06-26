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
            //Создание объекта ClassRoom, передавая в конструктор четырех учеников
            ClassRoom classRoom = new ClassRoom(
                new ExcellentPupil("Иванов"),
                new GoodPupil("Петров"),
                new BadPupil("Сидоров"),
                new GoodPupil("Козлов")
            );
            //// Вызов метода ShowPupils для объекта classRoom, который выводит информацию о каждом ученике и их действиях.
            classRoom.ShowPupils();
        }
    }
}
