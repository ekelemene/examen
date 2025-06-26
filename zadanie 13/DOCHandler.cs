using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс DOCHandler наследуется от абстрактного класса AbstractHandler
    /// </summary>
    class DOCHandler : AbstractHandler
    {
        /// <summary>
        /// Реализация метода открытия документа
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Открыт DOC документ");
        }

        /// <summary>
        /// Реализация метода создания документа
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Создан DOC документ");
        }

        /// <summary>
        /// Реализация метода изменения документа
        /// </summary>
        public override void Change()
        {
            Console.WriteLine("Изменён DOC документ");
        }

        /// <summary>
        /// Реализация метода сохранения документа
        /// </summary>
        public override void Save()
        {
            Console.WriteLine("Сохранён DOC документ");
        }
    }
}
