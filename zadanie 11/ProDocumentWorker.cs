using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Класс ProDocumentWorker наследуется от базового класса DocumentWorker
    /// </summary>
    class ProDocumentWorker : DocumentWorker
    {
        /// <summary>
        /// Переопределённый метод редактирования документа.
        /// В базовом классе, скорее всего, редактирование недоступно.
        /// Здесь же оно реализовано — пользователь может редактировать документ.
        /// </summary>
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        /// <summary>
        /// Переопределённый метод сохранения документа.
        /// В профессиональной версии доступно сохранение, но только в старом формате.
        /// Чтобы сохранить в других (новых) форматах — нужна версия Expert.
        /// </summary>
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
}
