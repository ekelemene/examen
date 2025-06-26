using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс для обработки документов
    /// </summary>
    class DocumentWorker
    {
        /// <summary>
        /// Виртуальный метод для открытия документа
        /// </summary>
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }

        /// <summary>
        /// Виртуальный метод для редактирования документа
        /// </summary>
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        /// <summary>
        /// Виртуальный метод для сохранения документа
        /// </summary>
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
}
