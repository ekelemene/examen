using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс представляет содержимое книги.
    /// </summary>
    class Content
    {
        /// <summary>
        ///  Закрытое поле, хранящее текст содержания
        /// </summary>
        private string content;

        /// <summary>
        /// Конструктор, принимающий текст содержания.
        /// </summary>
        /// <param name="content"></param>
        public Content(string content)
        {
            this.content = content;
        }
        /// <summary>
        /// Метод отображает содержание книги голубым цветом.
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Содержание: {content}");
            Console.ResetColor();
        }
    }
}
