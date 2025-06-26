using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    /// <summary>
    /// Класс Book представляет книгу
    /// </summary>
    class Book
    {
        /// <summary>
        /// поле книги со свойством
        /// </summary>
        public Title Title { get; set; }

        /// <summary>
        /// поле автор со свойством
        /// </summary>
        public Author Author { get; set; }

        /// <summary>
        /// поле содержание со свойством
        /// </summary>
        public Content Content { get; set; }

        /// <summary>
        /// Конструктор для инициализации книги с заголовком, автором и содержанием.
        /// </summary>
        /// <param name="title">Заголовок книги.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="content">Содержание книги.</param>
        public Book(Title title, Author author, Content content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        /// <summary>
        /// Отображает информацию о книге:
        /// заголовок, автора и содержание.
        /// </summary>
        public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
}