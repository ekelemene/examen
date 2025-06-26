using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Абстрактный класс — нельзя создать объект напрямую, только унаследовать
    /// </summary>
    abstract class AbstractHandler
    {
        /// <summary>
        /// // Абстрактный метод Open — должен быть реализован в наследниках
        /// </summary>
        public abstract void Open();
        /// <summary>
        ///     // Абстрактный метод Create — должен быть реализован в наследниках
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Абстрактный метод Change — должен быть реализован в наследниках
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Абстрактный метод Save — должен быть реализован в наследниках
        /// </summary>
        public abstract void Save();
    }
}
