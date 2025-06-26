using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс XMLHandler наследуется от абстрактного класса AbstractHandler
    /// </summary>
    class XMLHandler : AbstractHandler
    {
        /// <summary>
        /// Реализация метода открытия XML-документа
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Открыт XML документ");
        }

        /// <summary>
        /// Реализация метода создания XML-документа
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Создан XML документ");
        }

        /// <summary>
        /// Реализация метода изменения XML-документа
        /// </summary>
        public override void Change()
        {
            Console.WriteLine("Изменён XML документ");
        }

        /// <summary>
        /// Реализация метода сохранения XML-документа
        /// </summary>
        public override void Save()
        {
            Console.WriteLine("Сохранён XML документ");
        }
    }
}
