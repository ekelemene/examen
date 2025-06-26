using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс ExpertDocumentWorker наследуется от класса ProDocumentWorker
    /// </summary>
    class ExpertDocumentWorker : ProDocumentWorker
    {
        /// <summary>
        /// Переопределённый метод сохранения документа.
        /// Этот метод заменяет реализацию из базового класса ProDocumentWorker.
        /// </summary>
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в новом формате");
        }
    }
}
