using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс представляет заголовок книги.
    /// </summary>
    class Title
    {
        /// <summary>
        /// поле
        /// </summary>
        private string title;

        /// <summary>
        /// Конструктор, принимающий заголовок.
        /// </summary>
        /// <param name="title"></param>
        public Title(string title)
        {
            this.title = title;
        }

        /// <summary>
        ///Метод отображает заголовок книги красным цветом.
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Название: {title}");
            Console.ResetColor();
        }
    }
}
