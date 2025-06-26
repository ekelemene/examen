using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаём объект Player — реализует оба интерфейса
            Player player = new Player();
            //Сохраняем ссылку на Player как IPlayable — для воспроизведения
            IPlayable playable = player;
            //Сохраняем ссылку на Player как IRecodable — для записи
            IRecodable recordable = player;

            // Вызовы методов воспроизведения через интерфейс IPlayable
            playable.Play();
            playable.Pause();
            playable.Stop();
            // Вызовы методов воспроизведения через интерфейс IPlayable
            recordable.Record();
            recordable.Pause();
            recordable.Stop();
        }
    }
}
