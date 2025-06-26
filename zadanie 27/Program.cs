using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        //Метод для вывода элементов списка на экран
        static void PrintList(List<string> list)
        {
            Console.WriteLine("Список цветов:");
            int i;
            for (i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]); // Вывод каждого элемента списка
            }
            Console.WriteLine(); // Пустая строка для разделения
        }

        static void Main(string[] args)
        {
            try
            {
                // Создаем пустой список строк для хранения цветов
                List<string> colors = new List<string>();

                // 1. Добавление строчными буквами
                colors.Add("красный");
                colors.Add("синий");
                colors.Add("зелёный");
                Console.WriteLine("После добавления:");
                PrintList(colors);

                // 2. Преобразование в прописные
                int i;
                for (i = 0; i < colors.Count; i++)
                {
                    colors[i] = colors[i].ToUpper();
                }
                Console.WriteLine("После преобразования в прописные:");
                PrintList(colors);

                // 3. Количество элементов
                Console.WriteLine("Текущее количество элементов: " + colors.Count);

                // 4. Добавляем новый элемент в конец списка
                colors.Add("жёлтый");
                Console.WriteLine("После добавления в конец:");
                PrintList(colors);

                // 5. Вставляем новый элемент в начало списка (индекс 0)
                colors.Insert(0, "белый");
                Console.WriteLine("После добавления в начало:");
                PrintList(colors);

                //6. Удаляем третий элемент (индекс 2), если он существует
                if (colors.Count >= 3)
                {
                    colors.RemoveAt(2);
                }
                Console.WriteLine("После удаления третьего элемента:");
                PrintList(colors);

                //  Переворачиваем список — последний элемент становится первым и т.д.
                colors.Reverse();
                Console.WriteLine("После реверса:");
                PrintList(colors);
            }
            catch (Exception ex)
            {
                //исключение
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
