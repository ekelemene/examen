using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// класс автор 
    /// </summary>
    class Author
    {
        /// <summary>
        /// поле которое содержит имя автора
        /// </summary>
        private string author;

        /// <summary>
        /// конструктор принимает и созраняет имя автора
        /// </summary>
        /// <param name="author"> имя автора </param>
        public Author(string author)
        {
            this.author = author;
        }
        /// <summary>
        /// Метод Show выводит имя автора в консоль зеленым цветом
        /// </summary>
        public void Show()
        { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Автор: {author}"); //выводим имя втора 
            Console.ResetColor();
        }
    }
}
