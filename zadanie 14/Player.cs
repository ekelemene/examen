using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Player реализует два интерфейса: IPlayable и IRecodable
    /// </summary>
    class Player : IPlayable, IRecodable
    {
        /// <summary>
        /// Реализация метода Play из интерфейса IPlayable
        /// </summary>
        public void Play()
        {
            Console.WriteLine("Воспроизведение начато");
        }

        /// <summary>
        /// Общая реализация Pause и Stop — для интерфейса IPlayable
        /// </summary>
        public void Pause()
        {
            Console.WriteLine("Воспроизведение на паузе");
        }


        public void Stop()
        {
            Console.WriteLine("Воспроизведение остановлено");
        }

        /// <summary>
        /// Явная реализация метода Record из интерфейса IRecodable
        /// Вызывается только через переменную типа IRecodable
        /// </summary>
        void IRecodable.Record()
        {
            Console.WriteLine("Запись начата");
        }

        /// <summary>
        /// Явная реализация Pause и Stop для интерфейса IRecodable
        /// Не мешают реализации этих методов из IPlayable
        /// </summary>
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись на паузе");
        }


        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }
    }
}
