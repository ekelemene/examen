using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    ///  Интерфейс IPlayable — описывает функциональность воспроизведения
    /// </summary>
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    /// <summary>
    /// Интерфейс IRecodable — описывает функциональность записи
    /// </summary>
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
