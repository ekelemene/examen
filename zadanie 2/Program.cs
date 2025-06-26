using exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadanie
{
    /// <summary>
    /// главный класс
    /// </summary>
    class Program
    {
        /// <summary>
        /// точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //просим ввести название и считываем его 
            Console.Write("Введите название книги:");
            string bookTitle = Console.ReadLine();

            // Ввод имени автора
            Console.Write("Введите имя автора:");
            string authorName = Console.ReadLine();

            // Ввод содержания книги
            Console.Write("Введите содержание книги:");
            string bookContent = Console.ReadLine();

            // Создаём объекты классов Title, Author и Content с введёнными пользователем данными
            Title title = new Title(bookTitle);
            Author author = new Author(authorName);
            Content content = new Content(bookContent);

            // Создаём объект книги, передаём в него все компоненты
            Book book = new Book(title, author, content);

            // Выводим итоговую информацию о книге
            Console.WriteLine("\nИнформация о книге:\n");
            book.Show();

            // Ожидание ввода, чтобы окно не закрылось сразу
            Console.Read();



        }
    }
}