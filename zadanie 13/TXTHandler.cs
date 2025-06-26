using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс TXTHandler наследуется от абстрактного класса AbstractHandler
    /// </summary>
    class TXTHandler : AbstractHandler
    {
        /// <summary>
        /// Реализация метода открытия TXT-документа
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Открыт TXT документ");
        }

        /// <summary>
        /// Реализация метода создания TXT-документа
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Создан TXT документ");
        }

        /// <summary>
        /// Реализация метода изменения TXT-документа
        /// </summary>
        public override void Change()
        {
            Console.WriteLine("Изменён TXT документ");
        }

        /// <summary>
        /// Реализация метода сохранения TXT-документа
        /// </summary>
        public override void Save()
        {
            Console.WriteLine("Сохранён TXT документ");
        }
    }
}
