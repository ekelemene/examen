using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Структура Book представляет книгу с основными свойствами
    /// </summary>
    struct Book
    {
        /// <summary>
        ///  Приватные поля для хранения данных книги
        /// </summary>
        private string title;
        private string author;
        private int year;
        private int pages;

        /// <summary>
        ///  Конструктор структуры для инициализации всех полей при создании объекта
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="year"></param>
        /// <param name="pages"></param>
        public Book(string title, string author, int year, int pages)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pages = pages;
        }

        /// <summary>
        /// Метод для вывода информации о книге на консоль
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Название: " + title);
            Console.WriteLine("Автор: " + author);
            Console.WriteLine("Год издания: " + year);
            Console.WriteLine("Количество страниц: " + pages);
            Console.WriteLine();
        }
    }
}
